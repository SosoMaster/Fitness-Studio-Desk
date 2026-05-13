using FitnessStudioApp.MODELS;
using FitnessStudioApp.SERVICES;
using System.Windows.Forms;

namespace FitnessStudioApp.FORMS
{
    public partial class TrainerForm : Form
    {
        private readonly TrainerFormService _trainerFormService;
        private readonly int _userId;          

        private Trainer _trainer;              
        private IEnumerable<TrainingSession> _allSessions = new List<TrainingSession>();

        public TrainerForm(int userId, TrainerFormService trainerFormService)
        {
            InitializeComponent();
            _userId = userId;
            _trainerFormService = trainerFormService;
        }

        private async void TrainerForm_Load(object sender, EventArgs e)
        {
            try
            {
                _trainer = await _trainerFormService.GetTrainerByUserIdAsync(_userId);
                lblWelcome.Text = $"Welcome, {_trainer.User?.Username ?? "Trainer"}  |  Specialty: {_trainer.Specialty}";

                await LoadSessionsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvSessions_SelectionChanged(object sender, EventArgs e)
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
                TrainingSession session = new()
                {
                    TrainerId = _trainer.TrainerId,
                    Description = txtDescription.Text.Trim(),
                    StartTime = dtpStartTime.Value,
                    EndTime = dtpEndTime.Value,
                    Capacity = int.Parse(txtCapacity.Text),
                };

                await _trainerFormService.AddSessionAsync(session);

                MessageBox.Show("Session added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                grpAddSession.Visible = false;
                ClientSize = new System.Drawing.Size(ClientSize.Width, 445);

                await LoadSessionsAsync();
            }
            catch (FormatException)
            {
                MessageBox.Show("Capacity must be a number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnDeleteSession_Click(object sender, EventArgs e)
        {
            if (dgvSessions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a session to delete.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int sessionId = (int)dgvSessions.SelectedRows[0].Cells["TrainingSessionId"].Value;

            var confirm = MessageBox.Show(
                "Delete this session? All its bookings will also be removed.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                await _trainerFormService.DeleteSessionAsync(sessionId);
                await LoadSessionsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}