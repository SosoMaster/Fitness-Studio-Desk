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
        private readonly RegisterService _registerService;
        private readonly ClientRegisterService _clientRegisterService;
        private readonly TrainerRegisterService _trainerRegisterService;

        public RegisterForm(
            RegisterService registerService,
            ClientRegisterService clientRegisterService,
            TrainerRegisterService trainerRegisterService)
        {
            InitializeComponent();
            _registerService = registerService;
            _clientRegisterService = clientRegisterService;
            _trainerRegisterService = trainerRegisterService;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new()
                {
                    Username = txtUsername.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Password = txtPassword.Text,  
                };

                string role = cmbRoles.Text;

                User savedUser = await _registerService.RegisterAsync(user, role);

                // Navigate to the role-specific profile form
                switch (role)
                {
                    case "Client":
                        var clientForm = new ClientRegisterForm(
                            savedUser.UserId, _clientRegisterService);
                        clientForm.Show();
                        this.Hide();
                        break;

                    case "Trainer":
                        var trainerForm = new TrainerRegisterForm(
                            savedUser.UserId, _trainerRegisterService);
                        trainerForm.Show();
                        this.Hide();
                        break;

                    case "Admin":
                        MessageBox.Show(
                            "Admin registered successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e) { }
    }
}
