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
            try
            {
                _logger.Debug($"Зареждане на резервации за треньор Id={trainerId}");

                var result = await _dbSet
                    .Include(b => b.Client)
                        .ThenInclude(c => c.User)
                    .Include(b => b.TrainingSession)
                    .Where(b => b.TrainingSession.TrainerId == trainerId)
                    .OrderBy(b => b.TrainingSession.StartTime)
                    .ToListAsync();

                if (!result.Any())
                    _logger.Warn($"Няма резервации за треньор Id={trainerId}");

                return result;
            }
            catch (Exception ex)
            {
                _logger.Error($"Грешка при зареждане на резервации за треньор Id={trainerId}", ex);
                throw;
            }
        }
    }
}