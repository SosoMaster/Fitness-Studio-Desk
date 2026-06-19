using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.REPOSITORY.Interfaces;

namespace FitnessStudioApp.SERVICES;

public class ProgressService
{
    private readonly IProgressRepository _progressRepo;
    private readonly ILoggerService _logger;

    public ProgressService(IProgressRepository progressRepo)
    {
        _progressRepo = progressRepo;
        _logger = new LoggerService(typeof(ProgressService));
    }

    public double CalculateBMI(double weightKg, int heightCm)
    {
        double heightM = heightCm / 100.0;
        return weightKg / (heightM * heightM);
    }

    public double CalculateBodyFat(double bmi, int age, string gender)
    {
        int sex = gender.Equals("Male", StringComparison.OrdinalIgnoreCase) ? 1 : 0;
        return 1.20 * bmi + 0.23 * age - 10.8 * sex - 5.4;
    }

    public (double min, double max) HealthyBodyFatRange(string gender, int age)
    {
        if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
        {
            if (age < 40) return (8, 19);
            if (age < 60) return (11, 22);
            return (13, 25);
        }
        else
        {
            if (age < 40) return (21, 33);
            if (age < 60) return (23, 35);
            return (24, 36);
        }
    }

    public string LoseFatRecommendation(double bodyFatPercent, double bmi, string gender, int age)
    {
        var (minFat, maxFat) = HealthyBodyFatRange(gender, age);

        if (bodyFatPercent <= maxFat)
            return $"Your body fat ({bodyFatPercent:F1}%) is already within the healthy range " +
                   $"({minFat}–{maxFat}% for your age and gender). Maintain your current routine.";

        double excessFat = bodyFatPercent - maxFat;
        return $"Your body fat is {bodyFatPercent:F1}% — {excessFat:F1}% above the healthy max " +
               $"of {maxFat}% for your age and gender.\n\n" +
               "Recommended approach to lose fat:\n" +
               "• Maintain a caloric deficit of 300–500 kcal/day\n" +
               "• 3–5 sessions of cardio per week (30–45 min)\n" +
               "• Keep protein intake high (1.6–2.2 g per kg of body weight)\n" +
               "• Strength training 2–3x per week to preserve muscle\n" +
               "• Aim for 0.5–1 kg of fat loss per week";
    }

    public string GainMuscleRecommendation(double bodyFatPercent, double bmi, string gender, int age)
    {
        var (minFat, maxFat) = HealthyBodyFatRange(gender, age);

        string fatStatus = bodyFatPercent < minFat
            ? $"Your body fat ({bodyFatPercent:F1}%) is below the healthy minimum of {minFat}%. " +
              "Focus on a slight caloric surplus before aggressive muscle building.\n\n"
            : "";

        return fatStatus +
               $"Your BMI is {bmi:F1}. Recommended approach to gain muscle:\n\n" +
               "• Caloric surplus of 200–300 kcal/day above maintenance\n" +
               "• Protein intake: 2.0–2.4 g per kg of body weight\n" +
               "• Progressive overload strength training 4–5x per week\n" +
               "• Prioritise compound lifts (squat, deadlift, bench, rows)\n" +
               "• Sleep 7–9 hours per night for optimal recovery\n" +
               "• Expect 0.25–0.5 kg of muscle gain per week";
    }

    public async Task SaveProgressAsync(Progress progress)
    {
        try
        {
            _logger.Info($"Запазване на прогрес за клиент Id={progress.ClientId}");

            if (progress.ClientId <= 0)
                throw new Exception("Invalid client reference.");
            if (progress.Height <= 0)
                throw new Exception("Height must be greater than 0.");
            if (progress.Weight <= 0)
                throw new Exception("Weight must be greater than 0.");

            await _progressRepo.AddAsync(progress);
            _logger.Info($"Прогресът е запазен успешно за клиент Id={progress.ClientId}");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при запазване на прогрес за клиент Id={progress?.ClientId}", ex);
            throw;
        }
    }

    public async Task<List<Progress>> GetAllProgressAsync(int clientId)
    {
        try
        {
            _logger.Debug($"Зареждане на прогрес за клиент Id={clientId}");
            var all = await _progressRepo.GetAllAsync();
            return all.Where(p => p.ClientId == clientId).ToList();
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на прогрес за клиент Id={clientId}", ex);
            throw;
        }
    }
}