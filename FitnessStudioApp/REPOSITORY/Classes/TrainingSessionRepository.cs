using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitnessStudioApp.REPOSITORY.Classes
{
    public class TrainingSessionRepository : BaseRepository<TrainingSession>, ITrainingSessionRepository
    {
        public TrainingSessionRepository(FitnessStudioAppDbContext context) : base(context)
        {
        }


        public async Task<IEnumerable<TrainingSession>> GetSessionsByTrainerIdAsync(int trainerId)
        {
            return await _dbSet
                .Include(ts => ts.Bookings)
                    .ThenInclude(b => b.Client)
                        .ThenInclude(c => c.User)
                .Where(ts => ts.TrainerId == trainerId)
                .OrderBy(ts => ts.StartTime)
                .ToListAsync();
        }


        public async Task<IEnumerable<TrainingSession>> GetUpcomingSessionsByTrainerIdAsync(int trainerId)
        {
            return await _dbSet
                .Include(ts => ts.Bookings)
                    .ThenInclude(b => b.Client)
                        .ThenInclude(c => c.User)
                .Where(ts => ts.TrainerId == trainerId && ts.StartTime >= DateTime.Now)
                .OrderBy(ts => ts.StartTime)
                .ToListAsync();
        }
    }
}