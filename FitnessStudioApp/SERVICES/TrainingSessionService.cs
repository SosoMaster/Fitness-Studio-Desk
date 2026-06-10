using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES;

public class TrainingSessionService
{
    private readonly TrainingSessionRepository _sessionRepo;
    private readonly ClientRepository _clientRepo;
    private readonly TrainerRepository _trainerRepo;
    private readonly ILoggerService _logger;

    public TrainingSessionService(
        TrainingSessionRepository sessionRepo,
        ClientRepository clientRepo,
        TrainerRepository trainerRepo)
    {
        _sessionRepo = sessionRepo;
        _clientRepo = clientRepo;
        _trainerRepo = trainerRepo;
        _logger = new LoggerService(typeof(TrainingSessionService));
    }

    public async Task AddAsync(TrainingSession session)
    {
        try
        {
            _logger.Info("Добавяне на нова тренировъчна сесия");

            if (session == null)
            {
                _logger.Warn("Опит за добавяне на null сесия");
                throw new Exception("Session is null");
            }

            var trainer = await _trainerRepo.GetByIdAsync(session.TrainerId);
            if (trainer == null)
            {
                _logger.Warn($"Невалиден треньор Id={session.TrainerId}");
                throw new Exception("Invalid trainer");
            }

            await _sessionRepo.AddAsync(session);
            _logger.Info($"Сесията е добавена успешно за треньор Id={session.TrainerId}");
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при добавяне на сесия", ex);
            throw;
        }
    }

    public async Task Delete(TrainingSession entity)
    {
        try
        {
            _logger.Info($"Изтриване на сесия Id={entity?.TrainingSessionId}");

            if (entity == null)
            {
                _logger.Warn("Опит за изтриване на null сесия");
                throw new Exception("Session is null");
            }

            var existing = await _sessionRepo.GetByIdAsync(entity.TrainingSessionId);
            if (existing == null)
            {
                _logger.Warn($"Не е намерена сесия Id={entity.TrainingSessionId} за изтриване");
                throw new Exception("No session found");
            }

            await _sessionRepo.DeleteAsync(existing);
            _logger.Info($"Сесия Id={entity.TrainingSessionId} е изтрита успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при изтриване на сесия Id={entity?.TrainingSessionId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<TrainingSession>> GetAllAsync()
    {
        try
        {
            _logger.Debug("Зареждане на всички сесии");

            var sessions = await _sessionRepo.GetAllAsync();
            if (!sessions.Any())
            {
                _logger.Warn("Няма намерени сесии");
                throw new Exception("No sessions found");
            }

            return sessions;
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на сесии", ex);
            throw;
        }
    }

    public async Task<TrainingSession> GetByIdAsync(int id)
    {
        try
        {
            _logger.Debug($"Търсене на сесия Id={id}");

            var session = await _sessionRepo.GetByIdAsync(id);
            if (session == null)
            {
                _logger.Warn($"Не е намерена сесия Id={id}");
                throw new Exception("No session found");
            }

            return session;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на сесия Id={id}", ex);
            throw;
        }
    }

    public async Task Update(TrainingSession entity)
    {
        try
        {
            _logger.Info($"Обновяване на сесия Id={entity?.TrainingSessionId}");

            if (entity == null)
            {
                _logger.Warn("Опит за обновяване на null сесия");
                throw new Exception("Session is null");
            }

            var existing = await _sessionRepo.GetByIdAsync(entity.TrainingSessionId);
            if (existing == null)
            {
                _logger.Warn($"Не е намерена сесия Id={entity.TrainingSessionId} за обновяване");
                throw new Exception("No session found");
            }

            await _sessionRepo.UpdateAsync(entity);
            _logger.Info($"Сесия Id={entity.TrainingSessionId} е обновена успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при обновяване на сесия Id={entity?.TrainingSessionId}", ex);
            throw;
        }
    }
}