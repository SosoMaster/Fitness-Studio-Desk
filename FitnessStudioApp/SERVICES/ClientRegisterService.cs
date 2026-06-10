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
        // Age — under 18 needs parent approval message
        if (client.Age < 16)
        {
            _logger.Warn($"Невалидна възраст: {client.Age}");
            throw new Exception("Age must be at least 16.");
        }

        if (client.Age < 18)
        {
            _logger.Warn($"Клиент под 18 години: {client.Age}");
            throw new Exception(
                "Clients under 18 require parental approval.\n" +
                "Please visit one of our physical fitness locations to complete registration.");
        }

        // Height — 120 cm to 272 cm
        if (client.Height < 120 || client.Height > 272)
        {
            _logger.Warn($"Невалиден ръст: {client.Height}");
            throw new Exception("Height must be between 120 cm and 272 cm.");
        }

        // Weight — 40 kg to 200 kg
        if (client.Weight < 40 || client.Weight > 200)
        {
            _logger.Warn($"Невалидно тегло: {client.Weight}");
            throw new Exception("Weight must be between 40 kg and 200 kg.");
        }

        if (string.IsNullOrEmpty(client.Gender))
        {
            _logger.Warn("Не е избран пол при регистрация");
            throw new Exception("Please select a gender.");
        }
    }
}