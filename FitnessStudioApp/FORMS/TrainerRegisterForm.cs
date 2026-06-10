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

        private readonly LoginService _loginService;
        private readonly UserService _userService;

        private readonly RegisterService _registerService;
        private readonly ClientRegisterService _clientRegisterService;
        private readonly TrainerService _trainerService;
        private readonly ClientService _clientService;
        readonly AdminClientProgressService _adminClientProgressService;
        readonly AdminTrainerService _adminTrainerService;
        readonly TrainerFormService _trainerFormService;


        public TrainerRegisterForm(int userId, TrainerRegisterService trainerRegisterService, LoginService loginService, UserService userService, RegisterService registerService, ClientRegisterService clientRegisterService,
            TrainerService trainerService, ClientService clientService, AdminClientProgressService adminClientProgressService, AdminTrainerService adminTrainerService, TrainerFormService trainerFormService)
        {
            InitializeComponent();
            _userId = userId;
            _trainerRegisterService = trainerRegisterService;
            _loginService = loginService;
            _userService = userService;
            _registerService = registerService;
            _clientRegisterService = clientRegisterService;
            _trainerService = trainerService;
            _clientService = clientService;
            _adminClientProgressService = adminClientProgressService;
            _adminTrainerService = adminTrainerService;
            _trainerFormService = trainerFormService;




            cmbSpecialty.DataSource = Enum.GetValues(typeof(Specialty));
        }

        private async void btnFinishRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSpecialty.SelectedItem is null)
                {
                    throw new Exception("Please select a specialty.");
                }

                Trainer trainer = new()
                {
                    UserId = _userId,
                    Specialty = (Specialty)cmbSpecialty.SelectedItem,
                    Age = int.Parse(txtAge.Text),
                    Gender = _trainerRegisterService.Gender(rdbMale, rdbFemale),
                    YearsOfExperience = int.Parse(txtExperienceYears.Text)
                };

                await _trainerRegisterService.RegisterTrainerAsync(trainer);

                MessageBox.Show(
                    "Trainer profile created successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // TODO: open LoginForm here

                var loginForm = new LoginForm(_loginService, _userService, _registerService, _clientRegisterService, _trainerRegisterService, _clientService, _trainerService, _adminClientProgressService, _trainerFormService, _adminTrainerService);
                loginForm.FormClosed += (s, e) => this.Close();
                loginForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}