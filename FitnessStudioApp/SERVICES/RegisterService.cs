using FitnessStudioApp.FORMS;
using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.REPOSITORY.Interfaces;
using FitnessStudioApp.SERVICES.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES;

public class RegisterService
{
    private readonly UserService _userService;
    private readonly UserRepository _userRepo;
    private readonly AdminRepository _adminRepo;
    private UserService object1;
    private IUserRepository object2;
    private IAdminRepository object3;
    private readonly ILoggerService _logger;

    public RegisterService(
        UserService userService,
        UserRepository userRepo,
        AdminRepository adminRepo)
    {
        _userService = userService;
        _userRepo = userRepo;
        _adminRepo = adminRepo;
        _logger = new LoggerService(typeof(RegisterService));
    }

    public RegisterService(UserService object1, IUserRepository object2, IAdminRepository object3)
    {
        this.object1 = object1;
        this.object2 = object2;
        this.object3 = object3;
        _logger = new LoggerService(typeof(RegisterService));
    }

    public async Task<User> RegisterAsync(User user, string role)
    {
        try
        {
            _logger.Info($"Регистрация на потребител: {user?.Username} с роля: {role}");

            UserValidator.InfoFieldsValidate(user);

            var existing = await _userRepo.GetByUsernameAsync(user.Username);
            if (existing != null)
            {
                _logger.Warn($"Потребителското име вече съществува: {user.Username}");
                throw new Exception("Username already exists.");
            }

            if (role != "Client" && role != "Trainer" && role != "Admin")
            {
                _logger.Warn($"Невалидна роля: {role}");
                throw new Exception("Please select a valid role.");
            }

            await _userService.AddAsync(user);

            if (role == "Admin")
            {
                _logger.Info($"Създаване на Admin профил за UserId={user.UserId}");
                Admin admin = new() { UserId = user.UserId };
                await _adminRepo.AddAsync(admin);
            }

            _logger.Info($"Потребителят {user.Username} е регистриран успешно като {role}");
            return user;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при регистрация на потребител: {user?.Username}", ex);
            throw;
        }
    }
}