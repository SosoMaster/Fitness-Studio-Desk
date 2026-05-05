using FitnessStudioApp.FORMS.АdminForms;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.DTO;
using FitnessStudioApp.SERVICES;
using FitnessStudioApp.SERVICES.Helpers;
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
    public partial class AdminUsersForm : Form
    {
        readonly private UserService _userService;
        readonly private ClientService _clientService;
        readonly private TrainerService _trainerService;
        public AdminUsersForm(UserService userService, ClientService clientService, TrainerService trainerService)
        {
            InitializeComponent();
            _userService = userService;
            _clientService = clientService;
            _trainerService = trainerService;

        }

        private void lbxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void AdminUsersForm_Load(object sender, EventArgs e)
        {
            var clients = await _clientService.GetAddClientWithUserInfo();



            foreach (var clinet in clients)
            {
                lbxClients.Items.Add(clinet);
            }

            var trainers = await _trainerService.GetAddTrainerWithUserInfo();

            foreach (var trainer in trainers)
            {
                lbxTrainers.Items.Add(trainer);
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserValidator.ListBoxIndexChecked(lbxClients))
                {
                    var editClientForm = new EditClientForm();
                    editClientForm.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
