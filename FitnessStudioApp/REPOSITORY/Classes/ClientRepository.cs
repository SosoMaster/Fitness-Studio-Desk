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

public class ClientRepository: BaseRepository<Client>, IClientRepository
{

    public ClientRepository(FitnessStudioAppDbContext db) : base(db)
    {

    }

    public async Task<IEnumerable<ClientAndTrainerDTO>> GetAddClientWithUserInfo()
    {
       return await  _dbSet.Include(c => c.User).Select(c=> new ClientAndTrainerDTO
       {
           ModelId = c.ClientId,
           UserId = c.UserId,
           Name = c.User.Username
       }).ToListAsync();
    }
}
