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
    public partial class ClientRegisterForm : Form
    {
        private ClientRegisterService _clientRegisterService;
        public ClientRegisterForm(ClientRegisterService clientRegisterService)
        {
            InitializeComponent();
            _clientRegisterService = clientRegisterService;
        }
        

        private void btnFinishRegister_Click(object sender, EventArgs e)
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

            }
            catch
            {

            }
        }
    }
}
