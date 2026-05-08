using FitnessStudioApp.MODELS;
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
    public partial class RegisterForm : Form
    {
        private RegisterService _registerService;

        //da se dobavi login kopshe.

        public RegisterForm(RegisterService registerService)
        {
            InitializeComponent();
            _registerService = registerService;

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new()
                {
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Password = txtPassword.Text,

                };
                string role = cmbRoles.Text;
                await _registerService.RegisterAsync(user, role);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // logger.Error(ex.Message, ex.StackTrace)
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
