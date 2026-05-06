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
        var membership = await _dbSet.FirstOrDefaultAsync(m => m.ClientId == userId);

        if (membership != null)
        {
            membership.ExpirationDate = membership.ExpirationDate.AddMonths(1);
            _dbSet.Update(membership);
            await _db.SaveChangesAsync();
        }
    }

    public async Task<Membership?> ViewMembership(int userId)
    {
        return await _dbSet.FirstOrDefaultAsync(m => m.ClientId == userId);
    }

    public async Task EndMembership(int userId)
    {
        var membership = await _dbSet.FirstOrDefaultAsync(m => m.ClientId == userId);

        if (membership != null)
        {
            membership.IsActive = false;
            _dbSet.Update(membership);
            await _db.SaveChangesAsync();
        }
    }
}
