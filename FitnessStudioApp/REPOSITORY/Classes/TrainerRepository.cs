using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.DTO;
using FitnessStudioApp.REPOSITORY.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Classes;

public class TrainerRepository : BaseRepository<Trainer>, ITrainerRepository
{
    public TrainerRepository(FitnessStudioAppDbContext db) : base(db)
    {
    }

    public async Task<IEnumerable<ClientAndTrainerDTO>> GetAddTrainerWithUserInfo()
    {
        try
        {
            _logger.Debug("Зареждане на всички треньори с потребителска информация");

            var result = await _dbSet.Include(t => t.User).Select(t => new ClientAndTrainerDTO
            {
                UserId = t.UserId,
                ModelId = t.TrainerId,
                Name = t.User.Username
            }).ToListAsync();

            if (!result.Any())
                _logger.Warn("Няма намерени треньори");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на треньори", ex);
            throw;
        }
    }

    public async Task<IEnumerable<TrainerDTO>> GetAllTrainerForClientRegister()
    {
        try
        {
            _logger.Debug("Зареждане на треньори за регистрация на клиент");

            var result = await _dbSet.Include(t => t.User).Select(t => new TrainerDTO
            {
                Specialty = t.Specialty,
                Name = t.User.Username
            }).ToListAsync();

            if (!result.Any())
                _logger.Warn("Няма налични треньори за регистрация");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на треньори за регистрация", ex);
            throw;
        }
    }

    public async Task<Trainer> GetClientByUserId(int userId)
    {
        try
        {
            _logger.Debug($"Търсене на треньор по UserId={userId}");

            var trainer = await _dbSet.Where(c => c.UserId == userId).FirstOrDefaultAsync();

            if (trainer == null)
                _logger.Warn($"Не е намерен треньор с UserId={userId}");

            return trainer;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на треньор с UserId={userId}", ex);
            throw;
        }
    }
}
