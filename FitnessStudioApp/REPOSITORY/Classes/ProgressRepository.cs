using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Classes
{
    public class ProgressRepository : BaseRepository<Progress> /*IProgressRepository*/
    {
        public ProgressRepository(FitnessStudioAppDbContext db):base(db)
        {

        }
        /*public async Task<> GainWeight()
        {

        }*/
    }
}
