using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;

namespace FitnessStudioApp.SERVICES;

public class TrainerRegisterService
{
    private readonly ITrainerRepository _trainerRepo;
    private readonly ILoggerService _logger;

    public TrainerRegisterService(ITrainerRepository trainerRepo)
    {
        _trainerRepo = trainerRepo;
        _logger = new LoggerService(typeof(TrainerRegisterService));
    }
    public string Gender(RadioButton rdbMale, RadioButton rdbFemale)
    {
        if (rdbMale.Checked) return "Male";
        if (rdbFemale.Checked) return "Female";

        _logger.Warn("Не е избран пол при регистрация на клиент");
        throw new Exception("Please select a gender.");
    }

    public async Task RegisterTrainerAsync(Trainer trainer)
    {
        try
        {
            _logger.Info($"Регистрация на треньор с UserId={trainer?.UserId}");

            if (trainer.UserId <= 0)
            {
                _logger.Warn($"Невалидна потребителска референция UserId={trainer.UserId}");
                throw new Exception("Invalid user reference.");
            }

            // Only validate detailed trainer info if any of those fields are provided
            if (trainer.Age != 0 || !string.IsNullOrEmpty(trainer.Gender) || trainer.YearsOfExperience != 0)
            {
                ValidateTrainer(trainer.Age, trainer.Gender, trainer.YearsOfExperience);
            }

            await _trainerRepo.AddAsync(trainer);
            _logger.Info($"Треньорът е регистриран успешно с UserId={trainer.UserId}");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при регистрация на треньор с UserId={trainer?.UserId}", ex);
            throw;
        }
    }

    private void ValidateTrainer(int age, string gender, int experienceYears)
    {
        // Retirement age: 64 for male, 62 for female (Bulgarian retirement age)
        int maxAge = gender == "Female" ? 62 : 64;

        if (age < 18)
        {
            _logger.Warn($"Треньорът е под 18 години: {age}");
            throw new Exception("A trainer must be at least 18 years old.");
        }

        if (age > maxAge)
        {
            _logger.Warn($"Треньорът надвишава пенсионна възраст: {age}, пол: {gender}");
            throw new Exception(
                $"A {gender.ToLower()} trainer cannot be older than {maxAge} (Bulgarian retirement age).");
        }

        if (experienceYears < 0)
        {
            _logger.Warn($"Отрицателни години опит: {experienceYears}");
            throw new Exception("Years of experience cannot be negative.");
        }

        // Max experience: age minus 18 (earliest they could have started)
        int maxExperience = age - 18;
        if (experienceYears > maxExperience)
        {
            _logger.Warn($"Невалидни години опит: {experienceYears} за възраст {age}");
            throw new Exception(
                $"A trainer aged {age} can have a maximum of {maxExperience} years of experience " +
                $"(assuming they started at 18).");
        }
    }
}