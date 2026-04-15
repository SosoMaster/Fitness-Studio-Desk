using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.SERVICES.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES;

public class UserService : IService<User>
{
    private readonly FitnessStudioAppDbContext _db;
    private readonly UserRepository _userRepo; 

    public UserService(FitnessStudioAppDbContext db,UserRepository userRepo)
    {
        _db = db;
        _userRepo = userRepo;
    }

    public async Task AddAsync(User entity)
    {
        try
        {
            UserValidator.InfoFieldsValidate(entity);

            await _userRepo.AddAsync(entity);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Error",
                "Error",MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
    }

    public async Task Delete(User entity)
    {
        try
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
            await _userRepo.DeleteAsync(entity);

        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        try
        {
            if (_db.Set<User>().ToList().Count == 0)
            {
                throw new Exception("No Users found");
            }
            return await _userRepo.GetAllAsync();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<User> GetByIdAsync(int id)
    {
        try
        {
            var user = _db.Set<User>().FindAsync(id);

            if (user == null)
            {
                throw new Exception("No found user");
            }
            return await user;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public void Update(User entity)
    {
        throw new NotImplementedException();
    }
}
