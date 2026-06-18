using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.SERVICES;
using System.Windows.Forms;

namespace FitnessStudioApp.FORMS;

public partial class ProgressForm : Form
{
    private readonly ProgressService _progressService;
    private readonly ClientService _clientService;
    private readonly ILoggerService _logger;
    private readonly int _userId;

    private Client _client;
    private double _bmi;
    private double _bodyFat;

    public ProgressForm(int userId, ProgressService progressService, ClientService clientService)
    {
        InitializeComponent();
        _userId = userId;
        _progressService = progressService;
        _clientService = clientService;
        _logger = new LoggerService(typeof(ProgressForm));
    }

    private async void ProgressForm_Load(object sender, EventArgs e)
    {
        try
        {
            _logger.Debug($"Зареждане на ProgressForm за UserId={_userId}");

            _client = await _clientService.GetClientByUserId(_userId);

            txtCurrentWeight.Text = _client.Weight.ToString();
            txtCurrentHeight.Text = _client.Height.ToString();

            await LoadHistoryAsync();
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на ProgressForm за UserId={_userId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private bool TryCalculate(out double weight, out int height)
    {
        weight = 0;
        height = 0;

        if (!double.TryParse(txtCurrentWeight.Text.Trim(), out weight) || weight <= 0)
        {
            MessageBox.Show("Моля въведете валидно тегло.", "Валидация",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCurrentWeight.Focus();
            return false;
        }

        if (!int.TryParse(txtCurrentHeight.Text.Trim(), out height) || height <= 0)
        {
            MessageBox.Show("Моля въведете валиден ръст.", "Валидация",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCurrentHeight.Focus();
            return false;
        }

        _bmi = _progressService.CalculateBMI(weight, height);
        _bodyFat = _progressService.CalculateBodyFat(_bmi, _client.Age, _client.Gender);

        lblBMI.Text = $"BMI: {_bmi:F1}  ({BmiCategory(_bmi)})";
        lblBodyFat.Text = $"Body Fat: {_bodyFat:F1}%";

        return true;
    }

    private string BmiCategory(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        if (bmi < 25.0) return "Normal";
        if (bmi < 30.0) return "Overweight";
        return "Obese";
    }


    private void btnLoseFat_Click(object sender, EventArgs e)
    {
        try
        {
            if (!TryCalculate(out double weight, out int height)) return;

            _logger.Info($"Изчисляване на Lose Fat за UserId={_userId}, BMI={_bmi:F1}, BF={_bodyFat:F1}%");

            txtResult.Text = _progressService.LoseFatRecommendation(
                _bodyFat, _bmi, _client.Gender, _client.Age);
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при Lose Fat изчисление за UserId={_userId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private void btnGainMuscle_Click(object sender, EventArgs e)
    {
        try
        {
            if (!TryCalculate(out double weight, out int height)) return;

            _logger.Info($"Изчисляване на Gain Muscle за UserId={_userId}, BMI={_bmi:F1}, BF={_bodyFat:F1}%");

            txtResult.Text = _progressService.GainMuscleRecommendation(
                _bodyFat, _bmi, _client.Gender, _client.Age);
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при Gain Muscle изчисление за UserId={_userId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private async void btnSaveProgress_Click(object sender, EventArgs e)
    {
        try
        {
            if (!TryCalculate(out double weight, out int height)) return;

            _logger.Info($"Запазване на прогрес за UserId={_userId}");

            Progress progress = new()
            {
                ClientId = _client.ClientId,
                Age = _client.Age,
                Gender = _client.Gender,
                Height = height,
                Weight = weight,
            };

            await _progressService.SaveProgressAsync(progress);

            _logger.Info($"Прогресът е запазен успешно за UserId={_userId}");
            MessageBox.Show("Прогресът е запазен успешно!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            await LoadHistoryAsync();
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при запазване на прогрес за UserId={_userId}", ex);
            MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task LoadHistoryAsync()
    {
        try
        {
            var history = await _progressService.GetAllProgressAsync(_client.ClientId);

            dgvHistory.DataSource = history.Select(p => new
            {
                Weight = $"{p.Weight} kg",
                Height = $"{p.Height} cm",
                BMI = $"{_progressService.CalculateBMI(p.Weight, p.Height):F1}",
                BodyFat = $"{_progressService.CalculateBodyFat(_progressService.CalculateBMI(p.Weight, p.Height), p.Age, p.Gender):F1}%"
            }).ToList();
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на история за UserId={_userId}", ex);
        }
    }


    private void btnBack_Click(object sender, EventArgs e)
    {
        _logger.Debug($"Затваряне на ProgressForm за UserId={_userId}");
        var form = new Form();
        form.FormClosed += (s, e) => this.Close();
        this.Close();
    }
}