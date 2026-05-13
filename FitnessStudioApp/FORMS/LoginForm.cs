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

namespace FitnessStudioApp.FORMS
{
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

        public LoginForm(LoginService loginService, UserService userService, RegisterService registerService, ClientRegisterService clientRegisterService, TrainerRegisterService trainerRegisterService, ClientService clientService, TrainerService trainerService, AdminClientProgressService adminClientProgressService)
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
        }


        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await _loginService.LoginAsync(
                txtUsername.Text,
                txtPassword.Text);

                MessageBox.Show("Login successful!");



                if (user.Client != null)
                {
                    this.Hide();
                    new ClientForm(_userService).Show();
                }
                else if (user.Admin != null)
                {
                    this.Hide();
                    new AdminUsersForm(_userService, _clientService, _trainerService, _adminClientProgressService).Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }



        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(_registerService,_clientRegisterService, _trainerRegisterService );
            registerForm.Show();
            this.Hide();
        }
    }
}
