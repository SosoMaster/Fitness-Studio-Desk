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
        private UserService _userService;
        
        public RegisterForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
            
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {

            try
            {
                User user = new User()
                {
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Password = txtPassword.Text,

                };
               await _userService.AddAsync(user);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
