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
    public partial class EditClientForm : Form
    {
        readonly AdminClientProgressService _adminClientProgressService;
        readonly AdminTrainerService _adminTrainerService;
        readonly UserService _userService;
        readonly ClientService _clientService;
        readonly TrainerService _trainerService;
        private int _userId;
        public EditClientForm(int userId, AdminClientProgressService adminClientProgressService, UserService userService, ClientService clientService, AdminTrainerService adminTrainerService, TrainerService trainerService)
        {
            InitializeComponent();
            _adminClientProgressService = adminClientProgressService;
            _userService = userService;
            _clientService = clientService;
            _userId = userId;
            _adminTrainerService = adminTrainerService;
            _trainerService = trainerService;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminUsersForm(_userService, _clientService, _trainerService, _adminClientProgressService, _adminTrainerService);
            adminForm.Show();
            this.Close();
        }

        private async void EditClientForm_Load(object sender, EventArgs e)
        {
            try
            {
                var user = await _userService.GetByIdAsync(_userId);
                var client = await _clientService.GetClientByUserId(_userId);
                List<AdminProgressDTO> progresses = await _adminClientProgressService.GetAllProgressToClient(client.ClientId);

                foreach (var prog in progresses)
                {
                    lbxProgresses.Items.Add(prog);
                }

                tbxEmail.Text = user.Email;
                tbxPassword.Text = user.Password;
                tbxPhone.Text = user.Phone;
                tbxUsername.Text = user.Username;

                cbMembershipStatus.DataSource = Enum.GetValues(typeof(MembershipStatus));

               
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
                tbxPassword.UseSystemPasswordChar = !cbxShowPassword.Checked;
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
        }

        private async void btnUpdateData_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await _userService.GetByIdAsync(_userId);
                var client = await _clientService.GetClientByUserId(_userId);

                user.Username = tbxUsername.Text;
                user.Phone = tbxPhone.Text;
                user.Email = tbxEmail.Text;
                user.Password = tbxPassword.Text;

                await _userService.Update(user);

                client.MembershipStatus = (MembershipStatus)cbMembershipStatus.SelectedItem;

                await _clientService.Update(client);

                MessageBox.Show("Updated успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void btnDeleteProgress_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserValidator.ListBoxIndexChecked(lbxProgresses))
                {
                    /*var client = await _clientService.GetClientByUserId(_userId);
                    var progress = await _progressService.GetProgressByClientId(client.ClientId);
                    await _progressService.DeleteProgressAsync(progress);*/

                    var  progressDTO = lbxProgresses.SelectedItem as AdminProgressDTO;
                    var progress = await _adminClientProgressService.GetByIdAsync(progressDTO.ProgressId);
                     await _adminClientProgressService.DeleteProgressAsync(progress);
                } 
                else
                {

                }
            }
            catch (Exception)
            {

                throw;
            }    
        }
    }
}
