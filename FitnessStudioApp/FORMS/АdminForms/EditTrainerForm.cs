using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.DTO;
using FitnessStudioApp.MODELS.Enums;
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

namespace FitnessStudioApp.FORMS.АdminForms
{
    public partial class EditTrainerForm : Form
    {
        private int _userId;
        readonly TrainerService _trainerService;
        readonly UserService _userService;
        readonly AdminTrainerService _adminTrainerService;
        public EditTrainerForm(int userId, TrainerService trainerService, UserService userService, AdminTrainerService adminTrainerService)
        {
            InitializeComponent();
            _userId = userId;
            _trainerService = trainerService;
            _userService = userService;
            _adminTrainerService = adminTrainerService;
        }

        private async void EditTrainerForm_Load(object sender, EventArgs e)
        {
            var trainer = await _trainerService.GetClientByUserId(_userId);
            var user = await _userService.GetByIdAsync(_userId);

            tbxUsername.Text = user.Username;
            tbxPhone.Text = user.Phone;
            tbxEmail.Text = user.Email;
            tbxPassword.Text = user.Password;

            List<ClientAndTrainerDTO> clients = await _adminTrainerService.GetAllCklinetsToTrainer(trainer.TrainerId);

            foreach (ClientAndTrainerDTO client in clients)
            {
                lbClients.Items.Add(client);
            }

            cbxSpecialty.DataSource = Enum.GetValues(typeof(Specialty));


        }

        private async void btnUpdateData_Click(object sender, EventArgs e)
        {
            try
            {


                var user = await _userService.GetByIdAsync(_userId);
                var trainer = await _trainerService.GetClientByUserId(_userId);
                if (UserValidator.InfoFieldsValidate(user))
                {
                    user.Username = tbxUsername.Text;
                    user.Phone = tbxPhone.Text;
                    user.Email = tbxEmail.Text;
                    user.Password = tbxPassword.Text;
                    await _userService.Update(user);
                }

                // Update na clinet !~!!!!!

                trainer.Specialty = (Specialty)cbxSpecialty.SelectedItem;
                await _trainerService.Update(trainer);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnUpdateData_Click_1(object sender, EventArgs e)
        {
            try
            {
                var user = await _userService.GetByIdAsync(_userId);
                var trainer = await _trainerService.GetClientByUserId(_userId);

                if (UserValidator.InfoFieldsValidate(user))
                {
                    user.Username = tbxUsername.Text;
                    user.Phone = tbxPhone.Text;
                    user.Email = tbxEmail.Text;
                    user.Password = tbxPassword.Text;
                    await _userService.Update(user);
                }
                // Update na trainer !~!!!!!
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                tbxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
