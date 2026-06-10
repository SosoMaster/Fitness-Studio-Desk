using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.DTO;
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

namespace FitnessStudioApp.FORMS;

public partial class ClientRegisterForm : Form
{
    private readonly ClientRegisterService _clientRegisterService;
    private readonly TrainerService _trainerService;
    private readonly ILoggerService _logger;
    private int _userId;

    public ClientRegisterForm(int userId, ClientRegisterService clientRegisterService, TrainerService trainerService)
    {
        InitializeComponent();
        _userId = userId;
        _clientRegisterService = clientRegisterService;
        _trainerService = trainerService;
        _logger = new LoggerService(typeof(ClientRegisterForm));
    }

    private async void ClientRegisterForm_Load(object sender, EventArgs e)
    {
        try
        {
            _logger.Debug($"Зареждане на ClientRegisterForm за UserId={_userId}");

            var trainers = await _trainerService.GetAllTrainerForClientRegister();
            cmbTrainers.DataSource = trainers.ToList();
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на треньори", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnFinishRegister_Click(object sender, EventArgs e)
    {
        try
        {
            _logger.Info($"Регистрация на клиент за UserId={_userId}");

            TrainerDTO trainerDTO = cmbTrainers.SelectedItem as TrainerDTO;
            Trainer trainer =  await _trainerService.GetTrainerByNameAsync(trainerDTO.Name);

            if (trainer == null)
            {
                MessageBox.Show("Моля изберете треньор.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Client client = new()
            {
                Age = int.Parse(txtAge.Text),
                Gender = _clientRegisterService.Gender(rdbMale, rdbFemale),
                Height = int.Parse(txtHeight.Text),
                Weight = int.Parse(txtWeight.Text),
                TrainerId = trainer.TrainerId,
                UserId = _userId
            };

            await _clientRegisterService.RegisterClientAsync(client);

            _logger.Info($"Клиентът за UserId={_userId} е регистриран успешно");
            MessageBox.Show("Регистрацията е успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (FormatException ex)
        {
            _logger.Warn($"Невалиден формат на данните при регистрация на клиент UserId={_userId}");
            MessageBox.Show("Моля въведете валидни числа за възраст, ръст и тегло.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при регистрация на клиент UserId={_userId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    
}