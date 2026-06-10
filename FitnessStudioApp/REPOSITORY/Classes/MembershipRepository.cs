using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Classes;

public class MembershipRepository : BaseRepository<Membership>, IMembershipRepository
{
    public MembershipRepository(FitnessStudioAppDbContext db) : base(db)
    {
    }

    public async Task RenewMembership(int userId)
    {
        try
        {
            _logger.Debug($"Подновяване на членство за UserId={userId}");

            var membership = await _dbSet.FirstOrDefaultAsync(m => m.ClientId == userId);

            if (membership == null)
            {
                _logger.Warn($"Не е намерено членство за UserId={userId}");
                return;
            }

            membership.ExpirationDate = membership.ExpirationDate.AddMonths(1);
            _dbSet.Update(membership);
            await _db.SaveChangesAsync();

            _logger.Info($"Членството е подновено успешно за UserId={userId} до {membership.ExpirationDate}");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при подновяване на членство за UserId={userId}", ex);
            throw;
        }
    }

    public async Task<Membership?> ViewMembership(int userId)
    {
        try
        {
            _logger.Debug($"Зареждане на членство за UserId={userId}");

            var membership = await _dbSet.FirstOrDefaultAsync(m => m.ClientId == userId);

            if (membership == null)
                _logger.Warn($"Не е намерено членство за UserId={userId}");

            return membership;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на членство за UserId={userId}", ex);
            throw;
        }
    }

    public async Task EndMembership(int userId)
    {
        try
        {
            _logger.Debug($"Прекратяване на членство за UserId={userId}");

            var membership = await _dbSet.FirstOrDefaultAsync(m => m.ClientId == userId);

            if (membership == null)
            {
                _logger.Warn($"Не е намерено членство за UserId={userId}");
                return;
            }

            membership.IsActive = false;
            _dbSet.Update(membership);
            await _db.SaveChangesAsync();

            _logger.Info($"Членството е прекратено успешно за UserId={userId}");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при прекратяване на членство за UserId={userId}", ex);
            throw;
        }
    }
}
