using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.SERVICES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
    readonly AdminClientProgressService _adminClientProgressService;
    readonly AdminTrainerService _adminTrainerService;
    readonly TrainerFormService _trainerFormService;
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

    private async void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
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
                    var clientForm = new ClientRegisterForm(savedUser.UserId, _clientRegisterService, _trainerService);
                    clientForm.Show();
                    this.Hide();
                    break;

                case "Trainer":
                    _logger.Debug($"Пренасочване към TrainerRegisterForm за UserId={savedUser.UserId}");
                    var trainerForm = new TrainerRegisterForm(savedUser.UserId, _trainerRegisterService, _loginService, _userService, _registerService, _clientRegisterService, _trainerService, _clientService, _adminClientProgressService, _adminTrainerService, _trainerFormService);
                    trainerForm.Show();
                    this.Hide();
                    break;

                case "Admin":
                    _logger.Debug($"Администраторът е регистриран успешно UserId={savedUser.UserId}");
                    MessageBox.Show("Администраторът е регистриран успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private void RegisterForm_Load(object sender, EventArgs e) { }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            _logger.Debug("Пренасочване към LoginForm");
            var login = new LoginForm(_loginService, _userService, _registerService, _clientRegisterService, _trainerRegisterService, _clientService, _trainerService, _adminClientProgressService, _trainerFormService, _adminTrainerService);
            login.Show();
            this.Hide();
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при отваряне на LoginForm", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}