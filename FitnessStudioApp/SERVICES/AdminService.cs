using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY;
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
    private readonly UserService _userService;
    private readonly AdminRepository _adminRepo;

    public AdminService(UserService userService, AdminRepository adminRepository)
    {
        _userService = userService;
        _adminRepo = adminRepository;
    }

    public async Task AddAsync(User user, Admin admin)
    {
        UserValidator.InfoFieldsValidate(user);
        await _userService.AddAsync(user);

        admin.UserId = user.UserId;

        /*ClientValidator.InfoFieldsValidate(trainer);*/
        await _adminRepo.AddAsync(admin);

    }

    public async Task Delete(Admin entity)
    {
        if (entity == null)
        {
            throw new Exception("User is null");
        }

        var existing = await _adminRepo.GetByIdAsync(entity.AdminId);

        if (existing == null)
        {
            throw new Exception("No admin found! Can not delete.");
        }
        await _adminRepo.DeleteAsync(existing);
    }

    public async Task<IEnumerable<Admin>> GetAllAsync()
    {
        var clients = await _adminRepo.GetAllAsync();

        if (!clients.Any())
            throw new Exception("No clients found");   // може и без това?

        return clients;
    }

    public async Task<Admin> GetByIdAsync(int id)
    {
        var admin = await _adminRepo.GetByIdAsync(id);

        if (admin == null)
        {
            throw new Exception("No client user");
        }
        return admin;
    }

    public async Task Update(Admin entity)
    {
        /*ClientValidator.InfoFieldsValidate(entity);*/

        var client = await _adminRepo.GetByIdAsync(entity.AdminId);
        if (client == null)
        {
            throw new Exception("No client found");
        }

        await _adminRepo.UpdateAsync(entity);
    }

}
