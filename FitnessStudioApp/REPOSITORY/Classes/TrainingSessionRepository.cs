using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitnessStudioApp.REPOSITORY.Classes;

public class TrainingSessionRepository : BaseRepository<TrainingSession>, ITrainingSessionRepository
{
    public TrainingSessionRepository(FitnessStudioAppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<TrainingSession>> GetSessionsByTrainerIdAsync(int trainerId)
    {
        try
        {
            _logger.Debug($"Зареждане на всички сесии за треньор Id={trainerId}");

            var result = await _dbSet
                .Include(ts => ts.Bookings)
                    .ThenInclude(b => b.Client)
                        .ThenInclude(c => c.User)
                .Where(ts => ts.TrainerId == trainerId)
                .OrderBy(ts => ts.StartTime)
                .ToListAsync();

            if (!result.Any())
                _logger.Warn($"Няма намерени сесии за треньор Id={trainerId}");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на сесии за треньор Id={trainerId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<TrainingSession>> GetUpcomingSessionsByTrainerIdAsync(int trainerId)
    {
        try
        {
            _logger.Debug($"Зареждане на предстоящи сесии за треньор Id={trainerId}");

            var result = await _dbSet
                .Include(ts => ts.Bookings)
                    .ThenInclude(b => b.Client)
                        .ThenInclude(c => c.User)
                .Where(ts => ts.TrainerId == trainerId && ts.StartTime >= DateTime.Now)
                .OrderBy(ts => ts.StartTime)
                .ToListAsync();

            if (!result.Any())
                _logger.Warn($"Няма предстоящи сесии за треньор Id={trainerId}");

            return result;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на предстоящи сесии за треньор Id={trainerId}", ex);
            throw;
        }
    }
}