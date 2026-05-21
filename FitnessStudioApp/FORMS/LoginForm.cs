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
        readonly TrainerFormService _trainerFormService;

        public LoginForm(LoginService loginService, UserService userService, RegisterService registerService, ClientRegisterService clientRegisterService, TrainerRegisterService trainerRegisterService, ClientService clientService, TrainerService trainerService, AdminClientProgressService adminClientProgressService, TrainerFormService trainerFormService)
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
                /*var user = await _loginService.LoginAsync(
                txtUsername.Text,
                txtPassword.Text);

                MessageBox.Show("Login successful!");

                var checkUser = _userService.GetUserIncludeAllTables(txtUsername.Text);

                if (checkUser != null)
                {
                    this.Hide();
                    new ClientForm(_userService).Show();
                }
                else if (checkUser != null)
                {
                    this.Hide();
                    var form = new AdminUsersForm(_userService, _clientService, _trainerService, _adminClientProgressService);

                    form.FormClosed += (sender, e) => this.Close();
                    form.Show();
                }*/

                var user = await _loginService.LoginAsync(
           txtUsername.Text,
           txtPassword.Text);

                MessageBox.Show("Login successful!");

                // await е задължително!
                var checkUser = await _userService.GetUserIncludeAllTables(txtUsername.Text);

                if (checkUser.Client != null)
                {
                    this.Hide();
                    new ClientForm(_userService).Show();
                }
                else if (checkUser.Admin != null)
                {
                    this.Hide();
                    var form = new AdminUsersForm(_userService, _clientService, _trainerService, _adminClientProgressService);
                    form.FormClosed += (s, e) => this.Close();
                    form.Show();
                }
                else if (checkUser.Trainer != null)
                {
                    var form = new TrainerForm(checkUser.UserId, _trainerFormService);
                    form.FormClosed += (s, e) => this.Close();
                    form.Show();
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
            var registerForm = new RegisterForm(_registerService,_clientRegisterService, _trainerRegisterService , _trainerService);
            registerForm.Show();
            this.Hide();
        }
    }
}
