using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.DTO;
using FitnessStudioApp.REPOSITORY.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES;

public class AdminClientProgressService
{
    readonly ProgressRepository _progressRepository;
    private readonly ILoggerService _logger;

    public AdminClientProgressService(ProgressRepository progressRepository)
    {
        _progressRepository = progressRepository;
        _logger = new LoggerService(typeof(AdminClientProgressService));
    }

    public async Task<List<AdminProgressDTO>> GetAllProgressToClient(int clientId)
    {
        try
        {
            _logger.Debug($"Зареждане на прогрес за клиент Id={clientId}");

            var result = await _progressRepository.GetAllProgressToClient(clientId);

            if (!result.Any())
                _logger.Warn($"Няма намерен прогрес за клиент Id={clientId}");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на прогрес за клиент Id={clientId}", ex);
            throw;
        }
    }

    public async Task DeleteProgressAsync(Progress entity)
    {
        try
        {
            _logger.Info($"Изтриване на прогрес Id={entity?.ProgressId}");

            if (entity == null)
            {
                _logger.Warn("Опит за изтриване на null прогрес");
                throw new Exception("Progress is null");
            }

            await _progressRepository.DeleteAsync(entity);
            _logger.Info($"Прогрес Id={entity.ProgressId} е изтрит успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при изтриване на прогрес Id={entity?.ProgressId}", ex);
            throw;
        }
    }

    public async Task<Progress> GetProgressByClientId(int clientId)
    {
        try
        {
            _logger.Debug($"Търсене на прогрес за клиент Id={clientId}");

            var result = await _progressRepository.GetProgressByClientId(clientId);

            if (result == null)
                _logger.Warn($"Не е намерен прогрес за клиент Id={clientId}");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на прогрес за клиент Id={clientId}", ex);
            throw;
        }
    }

    public async Task<Progress> GetByIdAsync(int id)
    {
        try
        {
            _logger.Debug($"Търсене на прогрес Id={id}");

            var result = await _progressRepository.GetByIdAsync(id);

            if (result == null)
                _logger.Warn($"Не е намерен прогрес Id={id}");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на прогрес Id={id}", ex);
            throw;
        }
    }
}