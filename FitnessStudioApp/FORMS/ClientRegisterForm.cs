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

namespace FitnessStudioApp.FORMS
{
    public partial class ClientRegisterForm : Form
    {
        private ClientRegisterService _clientRegisterService;
        private int _userId;
        private readonly TrainerService _trainerService;

        public ClientRegisterForm(int userId, ClientRegisterService clientRegisterService, TrainerService trainerService)
        {
            InitializeComponent();
            _userId = userId;
            _clientRegisterService = clientRegisterService;
            _trainerService = trainerService;
        }


        private async void btnFinishRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new()
                {
                    Age = int.Parse(txtAge.Text),
                    Gender = _clientRegisterService.Gender(rdbMale, rdbFemale),
                    Height = int.Parse(txtHeight.Text),
                    Weight = int.Parse(txtWeight.Text),
                };
                await _clientRegisterService.RegisterClientAsync(client);

                MessageBox.Show("Registered успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void ClientRegisterForm_Load(object sender, EventArgs e)
        {
            var trainers = await _trainerService.GetAllAsync();
           
           
            cmbTrainers.DataSource = trainers;
        }
    }
}
