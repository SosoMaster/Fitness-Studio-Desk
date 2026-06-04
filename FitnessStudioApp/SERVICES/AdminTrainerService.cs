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

public class AdminTrainerService
{
    readonly ClientRepository _clientRepository;
    private readonly ILoggerService _logger;

    public AdminTrainerService(ClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
        _logger = new LoggerService(typeof(AdminTrainerService));
    }

    public async Task<List<ClientAndTrainerDTO>> GetAllCklinetsToTrainer(int trainerId)
    {
        try
        {
            _logger.Debug($"Зареждане на клиенти за треньор Id={trainerId}");

            var result = await _clientRepository.GetAllCklinetsToTrainer(trainerId);

            if (!result.Any())
                _logger.Warn($"Няма намерени клиенти за треньор Id={trainerId}");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на клиенти за треньор Id={trainerId}", ex);
            throw;
        }
    }
}
