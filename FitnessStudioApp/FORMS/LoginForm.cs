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
        private readonly LoginService _loginService;
        public LoginForm()
        {
            InitializeComponent();
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

                MessageBox.Show("Login successful!" );

                /*this.Hide();

                if (user.Role == Role.Client)
                {
                    new ClientProfileForm(user.UserId).Show();
                }
                else if(user.Role == Role.Trainer)
                {
                    new TrainerProfileForm(user.UserId).Show();
                }
                else if (user.Role == Role.Admin)
                {
                    new AdminProfileForm().Show();
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }
    }
}
