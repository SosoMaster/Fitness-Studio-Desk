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
    public partial class ClientForm : Form
    {


        readonly UserService _userservice;

        public ClientForm(UserService userService)
        {
            InitializeComponent();
            _userservice = userService;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ShowPassword_clientform.Checked)
            {
                txtb_Password_form.UseSystemPasswordChar = false;
            }
            else
            {
                txtb_Password_form.UseSystemPasswordChar = true;
            }
        }



        private async void btn_EditProfile_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _client.User;

                user.Username = textBox1.Text;
                user.Email = txtb_Email.Text;
                user.Phone = txtb_Phone.Text;
                user.Password = txtb_Password_form.Text;

                await _userService.Update(user);

                MessageBox.Show("Updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
        private readonly ClientService _clientService;
        private readonly UserService _userService;
        private int _userId;
        private Client _client;

        public ClientForm(int userId, ClientService clientService, UserService userService)
        {
            InitializeComponent();
            _userId = userId;
            _clientService = clientService;
            _userService = userService;
        }

       
       
    }
}
