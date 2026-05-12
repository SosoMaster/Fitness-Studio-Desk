using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.Enums;
using FitnessStudioApp.SERVICES;
using System.Windows.Forms;

namespace FitnessStudioApp.FORMS
{
    public partial class TrainerRegisterForm : Form
    {
        private readonly TrainerRegisterService _trainerRegisterService;
        private readonly int _userId;

        public TrainerRegisterForm(int userId, TrainerRegisterService trainerRegisterService)
        {
            InitializeComponent();
            _userId = userId;
            _trainerRegisterService = trainerRegisterService;

            
            cmbSpecialty.DataSource = Enum.GetValues(typeof(Specialty));
        }

        private async void btnFinishRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSpecialty.SelectedItem is null)
                    throw new Exception("Please select a specialty.");

                Trainer trainer = new()
                {
                    UserId = _userId,
                    Specialty = (Specialty)cmbSpecialty.SelectedItem, 
                };

                await _trainerRegisterService.RegisterTrainerAsync(trainer);

                MessageBox.Show(
                    "Trainer profile created successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // TODO: open LoginForm here
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}