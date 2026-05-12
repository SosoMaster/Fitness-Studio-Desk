using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.DTO;
using FitnessStudioApp.REPOSITORY.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Classes
{
    public class ProgressRepository : BaseRepository<Progress>, IProgressRepository
    {
        public ProgressRepository(FitnessStudioAppDbContext db):base(db)
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

        public async Task<List<AdminProgressDTO>> GetAllProgressToClient(int clientId)
        {
            return await _dbSet.Where(p => p.ClientId == clientId).Select(p => new AdminProgressDTO()
            {
                ProgressId = p.ProgressId,
                Weight = p.Weight,
                Height = p.Height,
            }).ToListAsync();
        }

        public async Task<Progress> GetProgressByClientId(int clientId)
        {
           return await _dbSet.Where(c => c.ClientId == clientId).FirstOrDefaultAsync();
        }

        public Task LoseWeight()
        {
            throw new NotImplementedException();
        }
        /*public async Task<> GainWeight()
{

}*/
    }
}
