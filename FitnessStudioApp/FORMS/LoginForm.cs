using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
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

namespace FitnessStudioApp.FORMS;

public partial class LoginForm : Form
{
    private readonly UserService _userService;
    private readonly LoginService _loginService;
    private readonly RegisterService _registerService;
    readonly ClientRegisterService _clientRegisterService;
    readonly TrainerRegisterService _trainerRegisterService;
    readonly ClientService _clientService;
    readonly TrainerService _trainerService;
    readonly AdminClientProgressService _adminClientProgressService;
    readonly AdminTrainerService _adminTrainerService;
    readonly TrainerFormService _trainerFormService;
    private readonly ILoggerService _logger;

    public LoginForm(LoginService loginService, UserService userService, RegisterService registerService, ClientRegisterService clientRegisterService, TrainerRegisterService trainerRegisterService, ClientService clientService, TrainerService trainerService, AdminClientProgressService adminClientProgressService, TrainerFormService trainerFormService, AdminTrainerService adminTrainerService)
    {
        _loginService = loginService;
        InitializeComponent();
        _userService = userService;
        _registerService = registerService;
        _clientRegisterService = clientRegisterService;
        _trainerRegisterService = trainerRegisterService;
        _clientService = clientService;
        _trainerService = trainerService;
        _adminClientProgressService = adminClientProgressService;
        _trainerFormService = trainerFormService;
        _adminTrainerService = adminTrainerService;
        _logger = new LoggerService(typeof(LoginForm));
    }

    private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !chbShowPassword.Checked;
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            _logger.Info($"Опит за влизане: {txtUsername.Text}");

            var user = await _loginService.LoginAsync(txtUsername.Text, txtPassword.Text);

            _logger.Info($"Потребителят {txtUsername.Text} влезе успешно");
            MessageBox.Show("Влизането е успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var checkUser = await _userService.GetUserIncludeAllTables(txtUsername.Text);

            if (checkUser.Client != null)
            {
                _logger.Debug($"Пренасочване към ClientForm за UserId={checkUser.UserId}");
                this.Hide();
                new ClientForm(checkUser.UserId, _clientService, _userService).Show();
            }
            else if (checkUser.Admin != null)
            {
                _logger.Debug($"Пренасочване към AdminUsersForm за UserId={checkUser.UserId}");
                this.Hide();
                var form = new AdminUsersForm(_userService, _clientService, _trainerService, _adminClientProgressService, _adminTrainerService);
                form.FormClosed += (s, e) => this.Close();
                form.Show();
            }
            else if (checkUser.Trainer != null)
            {
                _logger.Debug($"Пренасочване към TrainerForm за UserId={checkUser.UserId}");
                this.Hide();
                var form = new TrainerForm(checkUser.UserId, _trainerFormService);
                form.FormClosed += (s, e) => this.Close();
                form.Show();
            }
            else
            {
                _logger.Warn($"Потребителят {txtUsername.Text} няма назначена роля");
                MessageBox.Show("Потребителят няма назначена роля.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при влизане на потребител: {txtUsername.Text}", ex);
            MessageBox.Show("Влизането е неуспешно: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void lblUser_Click(object sender, EventArgs e) { }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            _logger.Debug("Отваряне на RegisterForm");
            var registerForm = new RegisterForm(_registerService, _clientRegisterService, _trainerRegisterService, _trainerService, _loginService, _adminClientProgressService, _adminTrainerService, _trainerFormService, _clientService);
            registerForm.Show();
            this.Hide();
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при отваряне на RegisterForm", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}