using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.SERVICES.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES;

public class AdminService
{
    private readonly AdminRepository _adminRepo;
    private readonly ILoggerService _logger;

    public AdminService(UserService userService, AdminRepository adminRepository)
    {
        _adminRepo = adminRepository;
        _logger = new LoggerService(typeof(AdminService));
    }

    public async Task Delete(Admin entity)
    {
        try
        {
            _logger.Info($"Изтриване на админ Id={entity?.AdminId}");

            if (entity == null)
            {
                _logger.Warn("Опит за изтриване на null админ");
                throw new Exception("User is null");
            }

            var existing = await _adminRepo.GetByIdAsync(entity.AdminId);
            if (existing == null)
            {
                _logger.Warn($"Не е намерен админ Id={entity.AdminId} за изтриване");
                throw new Exception("No admin found! Can not delete.");
            }

            await _adminRepo.DeleteAsync(existing);
            _logger.Info($"Админ Id={entity.AdminId} е изтрит успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при изтриване на админ Id={entity?.AdminId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<Admin>> GetAllAsync()
    {
        try
        {
            _logger.Debug("Зареждане на всички админи");

            var admins = await _adminRepo.GetAllAsync();
            if (!admins.Any())
            {
                _logger.Warn("Няма намерени админи");
                throw new Exception("No clients found");
            }

            return admins;
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на админи", ex);
            throw;
        }
    }

    public async Task<Admin> GetByIdAsync(int id)
    {
        try
        {
            _logger.Debug($"Търсене на админ Id={id}");

            var admin = await _adminRepo.GetByIdAsync(id);
            if (admin == null)
            {
                _logger.Warn($"Не е намерен админ Id={id}");
                throw new Exception("No client user");
            }

            return admin;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на админ Id={id}", ex);
            throw;
        }
    }

    public async Task Update(Admin entity)
    {
        try
        {
            _logger.Info($"Обновяване на админ Id={entity?.AdminId}");

            var admin = await _adminRepo.GetByIdAsync(entity.AdminId);
            if (admin == null)
            {
                _logger.Warn($"Не е намерен админ Id={entity.AdminId} за обновяване");
                throw new Exception("No client found");
            }

            await _adminRepo.UpdateAsync(entity);
            _logger.Info($"Админ Id={entity.AdminId} е обновен успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при обновяване на админ Id={entity?.AdminId}", ex);
            throw;
        }
    }
}