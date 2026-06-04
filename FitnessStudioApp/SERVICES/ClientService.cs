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

public class ClientService
{
    private readonly ClientRepository _clientRepo;
    private readonly ILoggerService _logger;

    public ClientService(ClientRepository clientRepository)
    {
        _clientRepo = clientRepository;
        _logger = new LoggerService(typeof(ClientService));
    }

    public async Task Delete(Client entity)
    {
        try
        {
            _logger.Info($"Изтриване на клиент Id={entity?.ClientId}");

            if (entity == null)
            {
                _logger.Warn("Опит за изтриване на null клиент");
                throw new Exception("User is null");
            }

            var existing = await _clientRepo.GetByIdAsync(entity.ClientId);
            if (existing == null)
            {
                _logger.Warn($"Не е намерен клиент Id={entity.ClientId} за изтриване");
                throw new Exception("No user found! Can not delete.");
            }

            await _clientRepo.DeleteAsync(existing);
            _logger.Info($"Клиент Id={entity.ClientId} е изтрит успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при изтриване на клиент Id={entity?.ClientId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<Client>> GetAllAsync()
    {
        try
        {
            _logger.Debug("Зареждане на всички клиенти");

            var clients = await _clientRepo.GetAllAsync();
            if (!clients.Any())
            {
                _logger.Warn("Няма намерени клиенти");
                throw new Exception("No clients found");
            }

            return clients;
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на клиенти", ex);
            throw;
        }
    }

    public async Task<Client> GetByIdAsync(int id)
    {
        try
        {
            _logger.Debug($"Търсене на клиент Id={id}");

            var client = await _clientRepo.GetByIdAsync(id);
            if (client == null)
            {
                _logger.Warn($"Не е намерен клиент Id={id}");
                throw new Exception("No client user");
            }

            return client;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на клиент Id={id}", ex);
            throw;
        }
    }

    public async Task Update(Client entity)
    {
        try
        {
            _logger.Info($"Обновяване на клиент Id={entity?.ClientId}");

            if (!ClientValidator.InfoFieldsValidate(entity))
            {
                _logger.Warn($"Невалидни данни за клиент Id={entity?.ClientId}");
                throw new Exception("Invalid client");
            }

            var client = await _clientRepo.GetByIdAsync(entity.ClientId);
            if (client == null)
            {
                _logger.Warn($"Не е намерен клиент Id={entity.ClientId} за обновяване");
                throw new Exception("No client found");
            }

            await _clientRepo.UpdateAsync(entity);
            _logger.Info($"Клиент Id={entity.ClientId} е обновен успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при обновяване на клиент Id={entity?.ClientId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<ClientAndTrainerDTO>> GetAddClientWithUserInfo()
    {
        try
        {
            _logger.Debug("Зареждане на клиенти с потребителска информация");
            return await _clientRepo.GetAddClientWithUserInfo();
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на клиенти с потребителска информация", ex);
            throw;
        }
    }

    public async Task<Client> GetClientByUserId(int userId)
    {
        try
        {
            _logger.Debug($"Търсене на клиент по UserId={userId}");

            var client = await _clientRepo.GetClientByUserId(userId);

            if (client == null)
                _logger.Warn($"Не е намерен клиент с UserId={userId}");

            return client;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на клиент с UserId={userId}", ex);
            throw;
        }
    }
}