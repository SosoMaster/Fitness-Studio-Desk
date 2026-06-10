using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.DTO;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.SERVICES.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES;

public class TrainerService
{
    private readonly TrainerRepository _trainerRepo;
    private readonly ILoggerService _logger;

    public TrainerService(UserService userService, TrainerRepository trainerRepository)
    {
        _trainerRepo = trainerRepository;
        _logger = new LoggerService(typeof(TrainerService));
    }

    public async Task Delete(Trainer entity)
    {
        try
        {
            _logger.Info($"Изтриване на треньор Id={entity?.TrainerId}");

            if (entity == null)
            {
                _logger.Warn("Опит за изтриване на null треньор");
                throw new Exception("Trainer is null");
            }

            var existing = await _trainerRepo.GetByIdAsync(entity.TrainerId);
            if (existing == null)
            {
                _logger.Warn($"Не е намерен треньор Id={entity.TrainerId} за изтриване");
                throw new Exception("No trainer found! Cannot delete.");
            }

            await _trainerRepo.DeleteAsync(existing);
            _logger.Info($"Треньор Id={entity.TrainerId} е изтрит успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при изтриване на треньор Id={entity?.TrainerId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<Trainer>> GetAllAsync()
    {
        try
        {
            _logger.Debug("Зареждане на всички треньори");

            var trainers = await _trainerRepo.GetAllAsync();
            if (!trainers.Any())
            {
                _logger.Warn("Няма намерени треньори");
                throw new Exception("No trainers found");
            }

            return trainers;
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на треньори", ex);
            throw;
        }
    }

    public async Task<Trainer> GetByIdAsync(int id)
    {
        try
        {
            _logger.Debug($"Търсене на треньор Id={id}");

            var trainer = await _trainerRepo.GetByIdAsync(id);
            if (trainer == null)
            {
                _logger.Warn($"Не е намерен треньор Id={id}");
                throw new Exception("No trainer found");
            }

            return trainer;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на треньор Id={id}", ex);
            throw;
        }
    }

    public async Task Update(Trainer entity)
    {
        try
        {
            _logger.Info($"Обновяване на треньор Id={entity?.TrainerId}");

            TrainerValidator.InfoFieldsValidate(entity);

            var trainer = await _trainerRepo.GetByIdAsync(entity.TrainerId);
            if (trainer == null)
            {
                _logger.Warn($"Не е намерен треньор Id={entity.TrainerId} за обновяване");
                throw new Exception("No trainer found");
            }

            await _trainerRepo.UpdateAsync(entity);
            _logger.Info($"Треньор Id={entity.TrainerId} е обновен успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при обновяване на треньор Id={entity?.TrainerId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<ClientAndTrainerDTO>> GetAddTrainerWithUserInfo()
    {
        try
        {
            _logger.Debug("Зареждане на треньори с потребителска информация");
            return await _trainerRepo.GetAddTrainerWithUserInfo();
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на треньори с потребителска информация", ex);
            throw;
        }
    }

    public async Task<Trainer> GetClientByUserId(int userId)
    {
        try
        {
            _logger.Debug($"Търсене на треньор по UserId={userId}");

            var trainer = await _trainerRepo.GetClientByUserId(userId);

            if (trainer == null)
                _logger.Warn($"Не е намерен треньор с UserId={userId}");

            return trainer;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на треньор с UserId={userId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<TrainerDTO>> GetAllTrainerForClientRegister()
    {
        try
        {
            _logger.Debug("Зареждане на треньори за регистрация на клиент");
            return await _trainerRepo.GetAllTrainerForClientRegister();
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на треньори за регистрация", ex);
            throw;
        }
    }

    public async Task<Trainer> GetTrainerByNameAsync(string name)
    {
        try
        {
            _logger.Debug($"Търсене на треньор по Name={name}");
            return await _trainerRepo.GetTrainerByNameAsync(name);
        }
        catch (Exception ex)
        {

            _logger.Error($"Грешка при търсене на треньор с Name={name}", ex);
            throw;
        }
    }
}
