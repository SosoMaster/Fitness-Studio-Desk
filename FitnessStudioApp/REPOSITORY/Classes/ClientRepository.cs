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

public class ClientRepository : BaseRepository<Client>, IClientRepository
{
    public ClientRepository(FitnessStudioAppDbContext db) : base(db)
    {
    }

    public async Task<IEnumerable<ClientAndTrainerDTO>> GetAddClientWithUserInfo()
    {
        try
        {
            _logger.Debug("Зареждане на всички клиенти с потребителска информация");

            var result = await _dbSet.Include(c => c.User).Select(c => new ClientAndTrainerDTO
            {
                ModelId = c.ClientId,
                UserId = c.UserId,
                Name = c.User.Username
            }).ToListAsync();

            if (!result.Any())
                _logger.Warn("Няма намерени клиенти");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error("Грешка при зареждане на клиенти", ex);
            throw;
        }
    }

    public async Task<List<ClientAndTrainerDTO>> GetAllCklinetsToTrainer(int trainerId)
    {
        try
        {
            _logger.Debug($"Зареждане на клиенти за треньор Id={trainerId}");

            var result = await _dbSet.Where(c => c.TrainerId == trainerId).Select(c => new ClientAndTrainerDTO
            {
                ModelId = c.ClientId,
                UserId = c.UserId,
                Name = c.User.Username
            }).ToListAsync();

            if (!result.Any())
                _logger.Warn($"Няма клиенти за треньор Id={trainerId}");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на клиенти за треньор Id={trainerId}", ex);
            throw;
        }
    }

    public async Task<Client> GetClientByUserId(int userId)
    {
        try
        {
            _logger.Debug($"Търсене на клиент по UserId={userId}");

            var client = await _dbSet.FirstOrDefaultAsync(c => c.UserId == userId);

            if (client == null)
            {
                _logger.Warn($"Не е намерен клиент с UserId={userId}");
                throw new Exception("Client not found!");
            }

            return client;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на клиент с UserId={userId}", ex);
            throw;
        }
    }
}
