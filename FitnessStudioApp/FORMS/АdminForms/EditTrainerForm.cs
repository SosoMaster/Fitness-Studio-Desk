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

public partial class EditTrainerForm : Form
{
    private int _userId;
    readonly TrainerService _trainerService;
    readonly UserService _userService;
    readonly AdminTrainerService _adminTrainerService;
    readonly AdminClientProgressService _adminClientProgressService;
    readonly ClientService _clientService;
    private readonly ILoggerService _logger;

    public EditTrainerForm(int userId, TrainerService trainerService, UserService userService, AdminTrainerService adminTrainerService, ClientService clientService, AdminClientProgressService adminClientProgressService)
    {
        InitializeComponent();
        _userId = userId;
        _trainerService = trainerService;
        _userService = userService;
        _adminTrainerService = adminTrainerService;
        _clientService = clientService;
        _adminClientProgressService = adminClientProgressService;
        _logger = new LoggerService(typeof(EditTrainerForm));
    }

    private async void EditTrainerForm_Load(object sender, EventArgs e)
    {
        try
        {
            _logger.Debug($"Зареждане на EditTrainerForm за UserId={_userId}");

            var trainer = await _trainerService.GetClientByUserId(_userId);
            var user = await _userService.GetByIdAsync(_userId);

            tbxUsername.Text = user.Username;
            tbxPhone.Text = user.Phone;
            tbxEmail.Text = user.Email;
            tbxPassword.Text = user.Password;

            List<ClientAndTrainerDTO> clients = await _adminTrainerService.GetAllCklinetsToTrainer(trainer.TrainerId);
            foreach (ClientAndTrainerDTO client in clients)
                lbClients.Items.Add(client);

            cbxSpecialty.DataSource = Enum.GetValues(typeof(Specialty));
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на EditTrainerForm за UserId={_userId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnUpdateData_Click(object sender, EventArgs e)
    {
        try
        {
            _logger.Info($"Обновяване на данни за треньор UserId={_userId}");

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

            trainer.Specialty = (Specialty)cbxSpecialty.SelectedItem;
            await _trainerService.Update(trainer);

            _logger.Info($"Данните за треньор UserId={_userId} са обновени успешно");
            MessageBox.Show("Данните са обновени успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при обновяване на треньор UserId={_userId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        tbxPassword.UseSystemPasswordChar = !cbxShowPassword.Checked;
    }

    private async void btnDeleteClient_Click(object sender, EventArgs e)
    {
        try
        {
            if (!UserValidator.ListBoxIndexChecked(lbClients))
            {
                MessageBox.Show("Моля изберете клиент.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clientDTO = lbClients.SelectedItem as ClientAndTrainerDTO;
            _logger.Info($"Изтриване на клиент Id={clientDTO.ModelId} от треньор UserId={_userId}");

            var client = await _clientService.GetByIdAsync(clientDTO.ModelId);
            await _clientService.Delete(client);

            lbClients.Items.RemoveAt(lbClients.SelectedIndex);

            _logger.Info($"Клиент Id={clientDTO.ModelId} е изтрит успешно");
            MessageBox.Show("Клиентът е изтрит успешно.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при изтриване на клиент", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        var adminForm = new AdminUsersForm(_userService, _clientService, _trainerService, _adminClientProgressService, _adminTrainerService);
        adminForm.Show();
        this.Close();
    }
}