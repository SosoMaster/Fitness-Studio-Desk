using FitnessStudioApp.Logger;
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

namespace FitnessStudioApp.FORMS.АdminForms;

public partial class EditClientForm : Form
{
    readonly AdminClientProgressService _adminClientProgressService;
    readonly AdminTrainerService _adminTrainerService;
    readonly UserService _userService;
    readonly ClientService _clientService;
    readonly TrainerService _trainerService;
    private readonly ILoggerService _logger;
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
        _logger = new LoggerService(typeof(EditClientForm));
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

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
            _logger.Debug($"Зареждане на EditClientForm за UserId={_userId}");

            var user = await _userService.GetByIdAsync(_userId);
            var client = await _clientService.GetClientByUserId(_userId);
            List<AdminProgressDTO> progresses = await _adminClientProgressService.GetAllProgressToClient(client.ClientId);

            foreach (var prog in progresses)
                lbxProgresses.Items.Add(prog);

            tbxEmail.Text = user.Email;
            tbxPassword.Text = user.Password;
            tbxPhone.Text = user.Phone;
            tbxUsername.Text = user.Username;

            cbMembershipStatus.DataSource = Enum.GetValues(typeof(MembershipStatus));
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на EditClientForm за UserId={_userId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        tbxPassword.UseSystemPasswordChar = !cbxShowPassword.Checked;
    }

    private async void btnUpdateData_Click(object sender, EventArgs e)
    {
        try
        {
            _logger.Info($"Обновяване на данни за UserId={_userId}");

            var user = await _userService.GetByIdAsync(_userId);
            var client = await _clientService.GetClientByUserId(_userId);

            user.Username = tbxUsername.Text;
            user.Phone = tbxPhone.Text;
            user.Email = tbxEmail.Text;
            user.Password = tbxPassword.Text;

            await _userService.Update(user);

            client.MembershipStatus = (MembershipStatus)cbMembershipStatus.SelectedItem;
            await _clientService.Update(client);

            _logger.Info($"Данните за UserId={_userId} са обновени успешно");
            MessageBox.Show("Данните са обновени успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при обновяване на данни за UserId={_userId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDeleteProgress_Click(object sender, EventArgs e)
    {
        try
        {
            if (!UserValidator.ListBoxIndexChecked(lbxProgresses))
            {
                MessageBox.Show("Моля изберете прогрес.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var progressDTO = lbxProgresses.SelectedItem as AdminProgressDTO;
            _logger.Info($"Изтриване на прогрес Id={progressDTO.ProgressId}");

            var progress = await _adminClientProgressService.GetByIdAsync(progressDTO.ProgressId);
            await _adminClientProgressService.DeleteProgressAsync(progress);

            lbxProgresses.Items.RemoveAt(lbxProgresses.SelectedIndex);

            _logger.Info($"Прогрес Id={progressDTO.ProgressId} е изтрит успешно");
            MessageBox.Show("Прогресът е изтрит успешно.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при изтриване на прогрес", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}