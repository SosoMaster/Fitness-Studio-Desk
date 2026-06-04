using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.SERVICES;
using System.Windows.Forms;

namespace FitnessStudioApp.FORMS;

public partial class TrainerForm : Form
{
    private readonly TrainerFormService _trainerFormService;
    private readonly ILoggerService _logger;
    private readonly int _userId;

    private Trainer _trainer;
    private IEnumerable<TrainingSession> _allSessions = new List<TrainingSession>();

    public TrainerForm(int userId, TrainerFormService trainerFormService)
    {
        InitializeComponent();
        _userId = userId;
        _trainerFormService = trainerFormService;
        _logger = new LoggerService(typeof(TrainerForm));
    }

    private async void TrainerForm_Load(object sender, EventArgs e)
    {
        try
        {
            _logger.Debug($"Зареждане на TrainerForm за UserId={_userId}");

            _trainer = await _trainerFormService.GetTrainerByUserIdAsync(_userId);
            lblWelcome.Text = $"Welcome, {_trainer.User?.Username ?? "Trainer"}  |  Specialty: {_trainer.Specialty}";

            await LoadSessionsAsync();
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на TrainerForm за UserId={_userId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task LoadSessionsAsync()
    {
        bool upcomingOnly = cmbFilter.SelectedIndex == 1;

        _allSessions = upcomingOnly
            ? await _trainerFormService.GetUpcomingSessionsAsync(_trainer.TrainerId)
            : await _trainerFormService.GetAllSessionsAsync(_trainer.TrainerId);

        dgvSessions.DataSource = _allSessions.Select(s => new
        {
            s.TrainingSessionId,
            Description = s.Description,
            Start = s.StartTime.ToString("dd/MM/yyyy HH:mm"),
            End = s.EndTime.ToString("dd/MM/yyyy HH:mm"),
            Capacity = s.Capacity,
            Booked = s.Bookings.Count
        }).ToList();

        if (dgvSessions.Columns.Contains("TrainingSessionId"))
            dgvSessions.Columns["TrainingSessionId"].Visible = false;

        ClearBookingsGrid();
    }

    private async void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_trainer == null) return;
        try
        {
            await LoadSessionsAsync();
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при филтриране на сесии", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvSessions_SelectionChanged(object sender, EventArgs e)
    {
        try
        {
            if (dgvSessions.SelectedRows.Count == 0)
            {
                ClearBookingsGrid();
                return;
            }

            var row = dgvSessions.SelectedRows[0];
            int sessionId = (int)row.Cells["TrainingSessionId"].Value;

            var session = _allSessions.FirstOrDefault(s => s.TrainingSessionId == sessionId);
            if (session == null)
            {
                ClearBookingsGrid();
                return;
            }

            lblSelectedSession.Text = $"Session: {session.Description}  |  {session.StartTime:dd/MM/yyyy HH:mm}";

            dgvBookings.DataSource = session.Bookings.Select(b => new
            {
                Client = b.Client?.User?.Username ?? "—",
                BookingDate = b.BookingDate.ToString("dd/MM/yyyy"),
                Status = b.Status
            }).ToList();
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при избор на сесия", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ClearBookingsGrid()
    {
        dgvBookings.DataSource = null;
        lblSelectedSession.Text = "← Select a session to see its bookings";
    }

    private void btnAddSession_Click(object sender, EventArgs e)
    {
        grpAddSession.Visible = !grpAddSession.Visible;

        if (grpAddSession.Visible)
        {
            ClientSize = new System.Drawing.Size(ClientSize.Width, 560);
            txtDescription.Clear();
            txtCapacity.Clear();
            dtpStartTime.Value = DateTime.Now.AddHours(1);
            dtpEndTime.Value = DateTime.Now.AddHours(2);
        }
        else
        {
            ClientSize = new System.Drawing.Size(ClientSize.Width, 445);
        }
    }

    private async void btnConfirmAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _logger.Info($"Добавяне на нова сесия за треньор Id={_trainer.TrainerId}");

            TrainingSession session = new()
            {
                TrainerId = _trainer.TrainerId,
                Description = txtDescription.Text.Trim(),
                StartTime = dtpStartTime.Value,
                EndTime = dtpEndTime.Value,
                Capacity = int.Parse(txtCapacity.Text),
            };

            await _trainerFormService.AddSessionAsync(session);

            _logger.Info($"Сесията е добавена успешно за треньор Id={_trainer.TrainerId}");
            MessageBox.Show("Сесията е добавена успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpAddSession.Visible = false;
            ClientSize = new System.Drawing.Size(ClientSize.Width, 445);

            await LoadSessionsAsync();
        }
        catch (FormatException)
        {
            _logger.Warn("Невалиден формат за капацитет");
            MessageBox.Show("Капацитетът трябва да е число.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при добавяне на сесия за треньор Id={_trainer.TrainerId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDeleteSession_Click(object sender, EventArgs e)
    {
        try
        {
            if (dgvSessions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Моля изберете сесия за изтриване.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sessionId = (int)dgvSessions.SelectedRows[0].Cells["TrainingSessionId"].Value;

            var confirm = MessageBox.Show(
                "Изтриване на сесията? Всички резервации също ще бъдат премахнати.",
                "Потвърждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            _logger.Info($"Изтриване на сесия Id={sessionId}");
            await _trainerFormService.DeleteSessionAsync(sessionId);

            _logger.Info($"Сесия Id={sessionId} е изтрита успешно");
            await LoadSessionsAsync();
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при изтриване на сесия", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}