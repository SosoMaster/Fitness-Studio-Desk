using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Classes;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(FitnessStudioAppDbContext db) : base(db)
    {
    }

    public async Task<User> GetByUsernameAsync(string username)
    {
        try
        {
            _logger.Debug($"Търсене на потребител по Username={username}");

            var user = await _dbSet.Where(u => u.Username == username).FirstOrDefaultAsync();

            if (user == null)
                _logger.Warn($"Не е намерен потребител с Username={username}");

            return user;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на потребител с Username={username}", ex);
            throw;
        }
    }

    public async Task<User> GetUserIncludeAllTables(string username)
    {
        try
        {
            _logger.Debug($"Зареждане на потребител с всички таблици за Username={username}");

            var user = await _db.Users
                .Include(u => u.Client)
                .Include(u => u.Trainer)
                .Include(u => u.Admin)
                .FirstOrDefaultAsync(u => u.Username == username);

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
