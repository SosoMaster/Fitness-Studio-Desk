using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.SERVICES;
using FitnessStudioApp.SERVICES.Helpers;
using System.Windows.Forms;

namespace FitnessStudioApp.FORMS;

public partial class RegisterForm : Form
{
    private readonly RegisterService _registerService;
    private readonly ClientRegisterService _clientRegisterService;
    private readonly TrainerRegisterService _trainerRegisterService;
    private readonly TrainerService _trainerService;
    private readonly UserService _userService;
    private readonly ClientService _clientService;
    private readonly LoginService _loginService;
    private readonly AdminClientProgressService _adminClientProgressService;
    private readonly AdminTrainerService _adminTrainerService;
    private readonly TrainerFormService _trainerFormService;
    private readonly ILoggerService _logger;

    public RegisterForm(
        RegisterService registerService,
        ClientRegisterService clientRegisterService,
        TrainerRegisterService trainerRegisterService,
        TrainerService trainerService,
        LoginService loginService,
        AdminClientProgressService adminClientProgressService,
        AdminTrainerService adminTrainerService,
        TrainerFormService trainerFormService,
        ClientService clientService)
    {
        InitializeComponent();
        _registerService = registerService;
        _clientRegisterService = clientRegisterService;
        _trainerRegisterService = trainerRegisterService;
        _trainerService = trainerService;
        _clientService = clientService;
        _loginService = loginService;
        _adminClientProgressService = adminClientProgressService;
        _adminTrainerService = adminTrainerService;
        _trainerFormService = trainerFormService;
        _logger = new LoggerService(typeof(RegisterForm));
    }

    private void btnShowPassword_Click(object sender, EventArgs e)
    {
        txtPassword.PasswordChar = txtPassword.PasswordChar == '\0' ? '●' : '\0';
        btnShowPassword.Text = txtPassword.PasswordChar == '\0' ? "HIDE" : "SHOW";
    }

    private void btnShowConfirm_Click(object sender, EventArgs e)
    {
        txtConfirmPassword.PasswordChar = txtConfirmPassword.PasswordChar == '\0' ? '●' : '\0';
        btnShowConfirm.Text = txtConfirmPassword.PasswordChar == '\0' ? "HIDE" : "SHOW";
    }


    private async void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            if (!ValidateInputs()) return;

            if (cmbRoles.SelectedItem == null)
            {
                MessageBox.Show("Моля изберете роля.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string role = cmbRoles.SelectedItem.ToString();
            _logger.Info($"Регистрация на нов потребител: {txtUsername.Text.Trim()} с роля: {role}");

            User user = new()
            {
                Username = txtUsername.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Password = txtPassword.Text,
            };

            User savedUser = await _registerService.RegisterAsync(user, role);
            _logger.Info($"Потребителят {savedUser.Username} е регистриран успешно като {role}");

            switch (role)
            {
                case "Client":
                    _logger.Debug($"Пренасочване към ClientRegisterForm за UserId={savedUser.UserId}");
                    this.Hide();
                    var clientForm = new ClientRegisterForm(savedUser.UserId, _clientRegisterService, _trainerService);
                    clientForm.FormClosed += (s, args) => this.Close();
                    clientForm.Show();
                    break;

                case "Trainer":
                    _logger.Debug($"Пренасочване към TrainerRegisterForm за UserId={savedUser.UserId}");
                    this.Hide();
                    var trainerForm = new TrainerRegisterForm(
                        savedUser.UserId, _trainerRegisterService, _loginService, _userService,
                        _registerService, _clientRegisterService, _trainerService, _clientService,
                        _adminClientProgressService, _adminTrainerService, _trainerFormService);
                    trainerForm.FormClosed += (s, args) => this.Close();
                    trainerForm.Show();
                    break;

                case "Admin":
                    _logger.Debug($"Администраторът е регистриран успешно UserId={savedUser.UserId}");
                    MessageBox.Show("Администраторът е регистриран успешно!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
            }
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при регистрация на потребител: {txtUsername.Text.Trim()}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private bool ValidateInputs()
    {
        if (string.IsNullOrWhiteSpace(txtUsername.Text))
        {
            _logger.Warn("Регистрация неуспешна: празно потребителско име");
            MessageBox.Show("Моля въведете потребителско име.", "Валидация",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtUsername.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtEmail.Text))
        {
            _logger.Warn("Регистрация неуспешна: празен имейл");
            MessageBox.Show("Моля въведете имейл.", "Валидация",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            _logger.Warn("Регистрация неуспешна: празна парола");
            MessageBox.Show("Моля въведете парола.", "Валидация",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPassword.Focus();
            return false;
        }

        if (txtPassword.Text != txtConfirmPassword.Text)
        {
            _logger.Warn("Регистрация неуспешна: паролите не съвпадат");
            MessageBox.Show("Паролите не съвпадат.", "Валидация",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtConfirmPassword.Focus();
            return false;
        }

        if (!UserValidator.ValidatePhone(txtPhone.Text.Trim()))
        {
            _logger.Warn($"Регистрация неуспешна: невалиден телефон: {txtPhone.Text.Trim()}");
            MessageBox.Show(
                "Невалиден телефонен номер.\nФормат: +359XXXXXXXXX или 0XXXXXXXXX (9 цифри след префикса).",
                "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPhone.Focus();
            return false;
        }

        return true;
    }

    private void RegisterForm_Load(object sender, EventArgs e) { }


    private void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            _logger.Debug("Пренасочване към LoginForm");
            this.Hide();
            var login = new LoginForm(
                _loginService, _userService, _registerService, _clientRegisterService,
                _trainerRegisterService, _clientService, _trainerService,
                _adminClientProgressService, _trainerFormService, _adminTrainerService);
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при отваряне на LoginForm", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}