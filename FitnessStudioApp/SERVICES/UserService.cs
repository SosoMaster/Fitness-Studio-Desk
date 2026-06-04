using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using FitnessStudioApp.SERVICES.Helpers;

namespace FitnessStudioApp.SERVICES;

public class UserService
{
    private readonly IUserRepository _userRepo;
    private readonly ILoggerService _logger;

    public UserService(IUserRepository userRepo)
    {
        _userRepo = userRepo;
        _logger = new LoggerService(typeof(UserService));
    }

    public async Task AddAsync(User entity)
    {
        try
        {
            _logger.Info($"Добавяне на потребител: {entity.Username}");

            if (!UserValidator.InfoFieldsValidate(entity))
            {
                _logger.Warn($"Валидацията е неуспешна за потребител: {entity.Username}");
                throw new Exception("Validation failed.");
            }

            await _userRepo.AddAsync(entity);
            _logger.Info($"Потребителят {entity.Username} е добавен успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при добавяне на потребител: {entity.Username}", ex);
            throw;
        }
    }

    public async Task Delete(User entity)
    {
        try
        {
            _logger.Info($"Изтриване на потребител Id={entity?.UserId}");

            if (entity == null)
            {
                _logger.Warn("Опит за изтриване на null потребител");
                throw new Exception("User is null");
            }

            var existing = await _userRepo.GetByIdAsync(entity.UserId);
            if (existing == null)
            {
                _logger.Warn($"Не е намерен потребител Id={entity.UserId} за изтриване");
                throw new Exception("No user found! Can not delete.");
            }

            await _userRepo.DeleteAsync(existing);
            _logger.Info($"Потребител Id={entity.UserId} е изтрит успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при изтриване на потребител Id={entity?.UserId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        try
        {
            _logger.Debug("Зареждане на всички потребители");

            var users = await _userRepo.GetAllAsync();
            if (!users.Any())
            {
                _logger.Warn("Няма намерени потребители");
                throw new Exception("No users found");
            }

            return users;
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на потребители", ex);
            throw;
        }
    }

    public async Task<User> GetByIdAsync(int id)
    {
        try
        {
            _logger.Debug($"Търсене на потребител Id={id}");

            var user = await _userRepo.GetByIdAsync(id);
            if (user == null)
            {
                _logger.Warn($"Не е намерен потребител Id={id}");
                throw new Exception("No found user");
            }

            return user;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на потребител Id={id}", ex);
            throw;
        }
    }

    public async Task Update(User entity)
    {
        try
        {
            _logger.Info($"Обновяване на потребител Id={entity.UserId}");

            if (!UserValidator.InfoFieldsValidate(entity))
            {
                _logger.Warn($"Валидацията е неуспешна при обновяване на потребител Id={entity.UserId}");
                throw new Exception("Validation failed.");
            }

            var user = await _userRepo.GetByIdAsync(entity.UserId);
            if (user == null)
            {
                _logger.Warn($"Не е намерен потребител Id={entity.UserId} за обновяване");
                throw new Exception("No found user");
            }

            await _userRepo.UpdateAsync(entity);
            _logger.Info($"Потребител Id={entity.UserId} е обновен успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при обновяване на потребител Id={entity.UserId}", ex);
            throw;
        }
    }

    public async Task<User> GetUserIncludeAllTables(string username)
    {
        try
        {
            _logger.Debug($"Зареждане на потребител с всички таблици за Username={username}");

            var user = await _userRepo.GetUserIncludeAllTables(username);

            if (user == null)
                _logger.Warn($"Не е намерен потребител с Username={username}");

            return user;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на потребител с Username={username}", ex);
            throw;
        }
    }
}