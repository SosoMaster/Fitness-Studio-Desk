using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.Enums;
using FitnessStudioApp.REPOSITORY.Interfaces;
using System.Windows.Forms;

namespace FitnessStudioApp.SERVICES;

public class ClientRegisterService
{
    private readonly IClientRepository _clientRepo;
    private readonly ILoggerService _logger;

    public ClientRegisterService(IClientRepository clientRepo)
    {
        _clientRepo = clientRepo;
        _logger = new LoggerService(typeof(ClientRegisterService));
    }

    public string Gender(RadioButton rdbMale, RadioButton rdbFemale)
    {
        if (rdbMale.Checked) return "Male";
        if (rdbFemale.Checked) return "Female";

        _logger.Warn("Не е избран пол при регистрация на клиент");
        throw new Exception("Please select a gender.");
    }

    public async Task RegisterClientAsync(Client client)
    {
        try
        {
            _logger.Info($"Регистрация на клиент с UserId={client?.UserId}");

            if (client.Age <= 0 || client.Age > 120)
            {
                _logger.Warn($"Невалидна възраст: {client.Age}");
                throw new Exception("Please enter a valid age (1-120).");
            }
            if (client.Height <= 0)
            {
                _logger.Warn($"Невалиден ръст: {client.Height}");
                throw new Exception("Please enter a valid height.");
            }
            if (client.Weight <= 0)
            {
                _logger.Warn($"Невалидно тегло: {client.Weight}");
                throw new Exception("Please enter a valid weight.");
            }
            if (string.IsNullOrEmpty(client.Gender))
            {
                _logger.Warn("Не е избран пол при регистрация");
                throw new Exception("Please select a gender.");
            }

            client.MembershipStatus = MembershipStatus.Inactive;

            await _clientRepo.AddAsync(client);
            _logger.Info($"Клиентът е регистриран успешно с UserId={client.UserId}");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при регистрация на клиент с UserId={client?.UserId}", ex);
            throw;
        }
    }
}