using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.SERVICES.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES;

public class UserService
{
    private readonly UserRepository _userRepo;

    public UserService(UserRepository userRepo)
    {
        _userRepo = userRepo;
    }

    public async Task AddAsync(User entity)
    {
        UserValidator.InfoFieldsValidate(entity);

        await _userRepo.AddAsync(entity);
    }

    public async Task Delete(User entity)
    {
        if (entity == null)
        {
            throw new Exception("User is null");
        }

        var existing = await _userRepo.GetByIdAsync(entity.UserId);

        if (existing == null)
        {
            throw new Exception("No user found! Can not delete.");
        }
        await _userRepo.DeleteAsync(existing);
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        var users = await _userRepo.GetAllAsync();

        if (!users.Any())
            throw new Exception("No users found");   // може и без това?

        return users;
    }

    public async Task<User> GetByIdAsync(int id)
    {
        var user =  await _userRepo.GetByIdAsync(id);

        if (user == null)
        {
            throw new Exception("No found user");
        }
        return  user;

    }

    public async Task Update(User entity)
    {
        UserValidator.InfoFieldsValidate(entity);

        var user = await _userRepo.GetByIdAsync(entity.UserId);

        if (user == null)
            throw new Exception("No found user");

        await _userRepo.UpdateAsync(entity);
    }
}
