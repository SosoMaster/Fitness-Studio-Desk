using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
namespace FitnessStudioApp.SERVICES;

public class LoginService
{
    private readonly UserRepository _userRepo;
    private readonly ILoggerService _logger;

    public LoginService(UserRepository userRepository)
    {
        _userRepo = userRepository;
        _logger = new LoggerService(typeof(LoginService));
    }

    public async Task<User> LoginAsync(string username, string password)
    {
        try
        {
            _logger.Info($"Опит за влизане на потребител: {username}");

            var user = await _userRepo.GetByUsernameAsync(username);
            if (user == null)
            {
                _logger.Warn($"Не е намерен потребител с Username={username}");
                throw new Exception("User not found");
            }

            if (user.Password != password)
            {
                _logger.Warn($"Грешна парола за потребител: {username}");
                throw new Exception("Invalid password");
            }

            _logger.Info($"Потребителят {username} влезе успешно");
            return user;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при влизане на потребител: {username}", ex);
            throw;
        }
    }
}