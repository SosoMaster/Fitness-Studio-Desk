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

public class TrainerRepository: BaseRepository<Trainer>, ITrainerRepository
{
    public TrainerRepository(FitnessStudioAppDbContext db) : base(db)
    {

    }

    public async Task<IEnumerable<ClientAndTrainerDTO>> GetAddTrainerWithUserInfo()
    {
        return await _dbSet.Include(t => t.User).Select(t => new ClientAndTrainerDTO
        {
            UserId = t.UserId,
            ModelId = t.TrainerId,
            Name = t.User.Username
        }).ToListAsync();
    }
}
