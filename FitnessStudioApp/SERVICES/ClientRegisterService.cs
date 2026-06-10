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

            ValidateClient(client);

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

    private void ValidateClient(Client client)
    {
        if (client == null)
        {
            _logger.Warn("Client is null during validation");
            throw new Exception("Invalid client.");
        }

        // Age must be a reasonable positive value (1-120)
        if (client.Age <= 0 || client.Age > 120)
        {
            _logger.Warn($"Invalid age: {client.Age}");
            throw new Exception("Please provide a valid age.");
        }

        // Height must be positive
        if (client.Height <= 0)
        {
            _logger.Warn($"Invalid height: {client.Height}");
            throw new Exception("Please provide a valid height.");
        }

        // Weight must be positive
        if (client.Weight <= 0)
        {
            _logger.Warn($"Invalid weight: {client.Weight}");
            throw new Exception("Please provide a valid weight.");
        }

        if (string.IsNullOrEmpty(client.Gender))
        {
            _logger.Warn("Gender not selected during registration");
            throw new Exception("Please select a gender.");
        }
    }
}