using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitnessStudioApp.REPOSITORY.Classes
{
    public class BookingRepository : BaseRepository<Booking>, IBookingRepository
    {
        public BookingRepository(FitnessStudioAppDbContext db) : base(db)
        {
        }


        public async Task<IEnumerable<Booking>> GetBookingsByTrainerIdAsync(int trainerId)
        {
            return await _dbSet
                .Include(b => b.Client)
                    .ThenInclude(c => c.User)
                .Include(b => b.TrainingSession)
                .Where(b => b.TrainingSession.TrainerId == trainerId)
                .OrderBy(b => b.TrainingSession.StartTime)
                .ToListAsync();
        }
    }
}