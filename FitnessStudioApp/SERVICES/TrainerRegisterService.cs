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

            await _trainerRepo.AddAsync(trainer);
            _logger.Info($"Треньорът е регистриран успешно с UserId={trainer.UserId}");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при регистрация на треньор с UserId={trainer?.UserId}", ex);
            throw;
        }
    }
}