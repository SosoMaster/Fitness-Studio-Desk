using FitnessStudioApp.MODELS;
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
    public partial class ClientForm : Form
    {
        private readonly ClientService _clientService;
        private readonly UserService _userService;
        private int _userId;
        private Client _client;

        private readonly int _currentClientId;
        private readonly TrainingSessionService _sessionService;
        private readonly TrainerService _trainerService;
        private readonly BookingTrainingService _bookingTrainingService;
        private List<TrainingSession> _allSessions = new();
        private DateTime? _selectedDate;

        public ClientForm(int userId,
            ClientService clientService,
            UserService userService,
            TrainingSessionService sessionService,
            TrainerService trainerService,
            BookingTrainingService bookingService)
        {
            InitializeComponent();

            _userId = userId;
            _clientService = clientService;
            _userService = userService;

            _sessionService = sessionService;
            _trainerService = trainerService;
            _bookingTrainingService = bookingService;

            _currentClientId = userId;

            this.Load += ClientForm_Load;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            cmb_Trainer.SelectedIndexChanged += cmb_Trainer_SelectedIndexChanged;
            btn_Create.Click += btn_Create_Click;
            btn_Cancel.Click += btn_Cancel_Click;
        }

        private async void ClientForm_Load(object? sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ShowPassword_clientform.Checked)
            {
                txtb_Password_form.UseSystemPasswordChar = false;
            }
            else
            {
                txtb_Password_form.UseSystemPasswordChar = true;
            }
        }

        private async void btn_EditProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (_client == null)
                    return;

                var user = _client.User;

                user.Username = textBox1.Text;
                user.Email = txtb_Email.Text;
                user.Phone = txtb_Phone.Text;
                user.Password = txtb_Password_form.Text;

                await _userService.Update(user);

                MessageBox.Show("Updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_EditProfile_Click_1(object sender, EventArgs e)
        {

        }
    }
}
