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
public class ProgressRepository : BaseRepository<Progress>, IProgressRepository
{
    public ProgressRepository(FitnessStudioAppDbContext db) : base(db)
    {
    }

    public Task GainMuscle()
    {
        throw new NotImplementedException();
    }

    public Task GainWeight()
    {
        throw new NotImplementedException();
    }

    public Task LoseWeight()
    {
        throw new NotImplementedException();
    }

    public async Task<List<AdminProgressDTO>> GetAllProgressToClient(int clientId)
    {
        try
        {
            _logger.Debug($"Зареждане на прогрес за клиент Id={clientId}");

            var result = await _dbSet
                .Where(p => p.ClientId == clientId)
                .Select(p => new AdminProgressDTO()
                {
                    ProgressId = p.ProgressId,
                    Weight = p.Weight,
                    Height = p.Height,
                }).ToListAsync();

            if (!result.Any())
                _logger.Warn($"Няма намерен прогрес за клиент Id={clientId}");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на прогрес за клиент Id={clientId}", ex);
            throw;
        }
    }

    public async Task<Progress> GetProgressByClientId(int clientId)
    {
        try
        {
            _logger.Debug($"Търсене на прогрес за клиент Id={clientId}");

            var result = await _dbSet.Where(c => c.ClientId == clientId).FirstOrDefaultAsync();

            if (result == null)
                _logger.Warn($"Не е намерен прогрес за клиент Id={clientId}");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на прогрес за клиент Id={clientId}", ex);
            throw;
        }
    }
}