using FitnessStudioApp.FORMS.АdminForms;
using FitnessStudioApp.Logger;
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

namespace FitnessStudioApp.FORMS;

public partial class AdminUsersForm : Form
{
    readonly private UserService _userService;
    readonly private ClientService _clientService;
    readonly private TrainerService _trainerService;
    readonly private AdminClientProgressService _adminClientProgressService;
    readonly private AdminTrainerService _adminTrainerService;
    private readonly ILoggerService _logger;

    public AdminUsersForm(UserService userService, ClientService clientService, TrainerService trainerService, AdminClientProgressService adminClientProgressService, AdminTrainerService adminTrainerService)
    {
        InitializeComponent();
        _userService = userService;
        _clientService = clientService;
        _trainerService = trainerService;
        _adminClientProgressService = adminClientProgressService;
        _adminTrainerService = adminTrainerService;
        _logger = new LoggerService(typeof(AdminUsersForm));
    }

    private async void AdminUsersForm_Load(object sender, EventArgs e)
    {
        try
        {
            _logger.Debug("Зареждане на AdminUsersForm");

            var clients = await _clientService.GetAddClientWithUserInfo();
            foreach (var client in clients)
                lbxClients.Items.Add(client);

            var trainers = await _trainerService.GetAddTrainerWithUserInfo();
            foreach (var trainer in trainers)
                lbxTrainers.Items.Add(trainer);
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на AdminUsersForm", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEditClient_Click(object sender, EventArgs e)
    {
        try
        {
            if (UserValidator.ListBoxIndexChecked(lbxClients))
            {
                var client = lbxClients.SelectedItem as ClientAndTrainerDTO;
                _logger.Info($"Отваряне на EditClientForm за UserId={client.UserId}");
                var editClientForm = new EditClientForm(client.UserId, _adminClientProgressService, _userService, _clientService, _adminTrainerService, _trainerService);
                editClientForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Моля изберете клиент.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при отваряне на EditClientForm", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDeleteClient_Click(object sender, EventArgs e)
    {
        try
        {
            if (!UserValidator.ListBoxIndexChecked(lbxClients))
            {
                MessageBox.Show("Моля изберете клиент.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clientDTO = lbxClients.SelectedItem as ClientAndTrainerDTO;
            _logger.Info($"Изтриване на клиент UserId={clientDTO.UserId}");

            var user = await _userService.GetByIdAsync(clientDTO.UserId);
            var client = await _clientService.GetByIdAsync(clientDTO.ModelId);

            await _clientService.Delete(client);
            await _userService.Delete(user);

            lbxClients.Items.RemoveAt(lbxClients.SelectedIndex);

            _logger.Info($"Клиент UserId={clientDTO.UserId} е изтрит успешно");
            MessageBox.Show("Клиентът беше изтрит успешно.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при изтриване на клиент", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDeleteTrainer_Click(object sender, EventArgs e)
    {
        try
        {
            if (!UserValidator.ListBoxIndexChecked(lbxTrainers))
            {
                MessageBox.Show("Моля изберете треньор.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var trainerDTO = lbxTrainers.SelectedItem as ClientAndTrainerDTO;
            _logger.Info($"Изтриване на треньор UserId={trainerDTO.UserId}");

            var user = await _userService.GetByIdAsync(trainerDTO.UserId);
            var trainer = await _trainerService.GetByIdAsync(trainerDTO.ModelId);

            await _trainerService.Delete(trainer);
            await _userService.Delete(user);

            lbxTrainers.Items.RemoveAt(lbxTrainers.SelectedIndex);

            _logger.Info($"Треньор UserId={trainerDTO.UserId} е изтрит успешно");
            MessageBox.Show("Треньорът беше изтрит успешно.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при изтриване на треньор", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEditTrainer_Click(object sender, EventArgs e)
    {
        try
        {
            if (UserValidator.ListBoxIndexChecked(lbxTrainers))
            {
                var trainer = lbxTrainers.SelectedItem as ClientAndTrainerDTO;
                _logger.Info($"Отваряне на EditTrainerForm за UserId={trainer.UserId}");
                var editTrainerForm = new EditTrainerForm(trainer.UserId, _trainerService, _userService, _adminTrainerService, _clientService, _adminClientProgressService);
                editTrainerForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Моля изберете треньор.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при отваряне на EditTrainerForm", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}