using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Classes
{
    public class TrainingSessionRepository : BaseRepository<TrainingSession>, ITrainingSessionRepository
    {
        public TrainingSessionRepository(FitnessStudioAppDbContext context) : base(context)
        {

        }


    }
}

