using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.SERVICES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessStudioApp.FORMS
{
    public partial class BookingForm : Form
    {
        private readonly int _currentClientId;

        private readonly TrainingSessionService _sessionService;
        private readonly TrainerService _trainerService;

        private readonly BookingTrainingService _bookingTrainingService;

        private List<TrainingSession> _allSessions = new();
        private DateTime? _selectedDate;

        public BookingForm(int clientId)
        {
            InitializeComponent();

            _currentClientId = clientId;

            var db = new FitnessStudioAppDbContext();

            var trainerRepo = new TrainerRepository(db);
            var sessionRepo = new TrainingSessionRepository(db);
            var clientRepo = new ClientRepository(db);

            _trainerService = new TrainerService(null, trainerRepo);

            _sessionService = new TrainingSessionService(
                sessionRepo,
                clientRepo,
                trainerRepo);

            var bookingRepo = new BaseRepository<Booking>(db);

            _bookingTrainingService = new BookingTrainingService(
                bookingRepo,
                sessionRepo,
                clientRepo);

            this.Load += BookingForm_Load;

            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            cmb_Trainer.SelectedIndexChanged += cmb_Trainer_SelectedIndexChanged;
        }

        private async void BookingForm_Load(object? sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var trainers = await _trainerService.GetAddTrainerWithUserInfo();

            cmb_Trainer.DisplayMember = "Name";
            cmb_Trainer.ValueMember = "ModelId";
            cmb_Trainer.DataSource = trainers.ToList();

            var sessions = await _sessionService.GetAllAsync();

            _allSessions = sessions.ToList();

            UpdateSessionComboBox();

            monthCalendar1.MinDate = DateTime.Today;
            monthCalendar1.MaxDate = DateTime.Today.AddMonths(6);
        }

        private async void btn_Create_Click(object sender, EventArgs e)
        {
            if (cmb_TrainingSession.SelectedIndex == -1 ||
                cmb_TrainingSession.SelectedValue == null)
            {
                MessageBox.Show("Моля, изберете тренировка!");
                return;
            }

            int trainingSessionId =
                Convert.ToInt32(cmb_TrainingSession.SelectedValue);

            var session = _allSessions
                .FirstOrDefault(s => s.TrainingSessionId == trainingSessionId);

            if (session == null)
            {
                MessageBox.Show("Невалидна тренировка!");
                return;
            }

            Booking booking = new()
            {
                ClientId = _currentClientId,
                TrainingSessionId = trainingSessionId,
                BookingDate = session.StartTime,
                Status = "Active"
            };

            await _bookingTrainingService.AddAsync(booking);

            MessageBox.Show("Успешна резервация!");

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Trainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateSessionComboBox();
            }
            catch
            {

            }
        }

        private void monthCalendar1_DateSelected(
            object? sender,
            DateRangeEventArgs e)
        {
            _selectedDate = e.Start.Date;

            UpdateSessionComboBox();
        }

        private void UpdateSessionComboBox()
        {
            IEnumerable<TrainingSession> filtered = _allSessions;

            if (_selectedDate.HasValue)
            {
                filtered = filtered.Where(
                    s => s.StartTime.Date == _selectedDate.Value.Date);
            }

            if (cmb_Trainer.SelectedValue != null)
            {
                try
                {
                    int trainerId =
                        Convert.ToInt32(cmb_Trainer.SelectedValue);

                    filtered = filtered.Where(
                        s => s.TrainerId == trainerId);
                }
                catch
                {

                }
            }

            var list = filtered
                .OrderBy(s => s.StartTime)
                .Select(s => new
                {
                    Id = s.TrainingSessionId,
                    Name =
                        $"{s.StartTime:dd.MM.yyyy HH:mm} - " +
                        $"{s.EndTime:HH:mm} ({s.Description})"
                })
                .ToList();

            cmb_TrainingSession.DisplayMember = "Name";
            cmb_TrainingSession.ValueMember = "Id";
            cmb_TrainingSession.DataSource = list;
        }
    }
}
