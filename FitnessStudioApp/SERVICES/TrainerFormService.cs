using FitnessStudioApp.Logger;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;

namespace FitnessStudioApp.SERVICES;

public class TrainerFormService
{
    private readonly TrainerRepository _trainerRepo;
    private readonly TrainingSessionRepository _sessionRepo;
    private readonly BookingRepository _bookingRepo;
    private readonly ILoggerService _logger;

    public TrainerFormService(
        TrainerRepository trainerRepo,
        TrainingSessionRepository sessionRepo,
        BookingRepository bookingRepo)
    {
        _trainerRepo = trainerRepo;
        _sessionRepo = sessionRepo;
        _bookingRepo = bookingRepo;
        _logger = new LoggerService(typeof(TrainerFormService));
    }

    public async Task<Trainer> GetTrainerByUserIdAsync(int userId)
    {
        try
        {
            _logger.Debug($"Търсене на треньор по UserId={userId}");

            var trainer = await _trainerRepo.GetClientByUserId(userId);
            if (trainer == null)
            {
                _logger.Warn($"Не е намерен профил на треньор с UserId={userId}");
                throw new Exception("Trainer profile not found.");
            }

            return trainer;
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при търсене на треньор с UserId={userId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<TrainingSession>> GetAllSessionsAsync(int trainerId)
    {
        try
        {
            _logger.Debug($"Зареждане на всички сесии за треньор Id={trainerId}");
            return await _sessionRepo.GetSessionsByTrainerIdAsync(trainerId);
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на сесии за треньор Id={trainerId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<TrainingSession>> GetUpcomingSessionsAsync(int trainerId)
    {
        try
        {
            _logger.Debug($"Зареждане на предстоящи сесии за треньор Id={trainerId}");
            return await _sessionRepo.GetUpcomingSessionsByTrainerIdAsync(trainerId);
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на предстоящи сесии за треньор Id={trainerId}", ex);
            throw;
        }
    }

    public async Task<IEnumerable<Booking>> GetAllBookingsAsync(int trainerId)
    {
        try
        {
            _logger.Debug($"Зареждане на резервации за треньор Id={trainerId}");
            return await _bookingRepo.GetBookingsByTrainerIdAsync(trainerId);
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при зареждане на резервации за треньор Id={trainerId}", ex);
            throw;
        }
    }

    public async Task AddSessionAsync(TrainingSession session)
    {
        try
        {
            _logger.Info($"Добавяне на нова сесия за треньор Id={session?.TrainerId}");

            if (string.IsNullOrWhiteSpace(session.Description))
            {
                _logger.Warn("Опит за добавяне на сесия без описание");
                throw new Exception("Please enter a session description.");
            }
            if (session.Capacity <= 0)
            {
                _logger.Warn($"Невалиден капацитет: {session.Capacity}");
                throw new Exception("Capacity must be greater than 0.");
            }
            if (session.EndTime <= session.StartTime)
            {
                _logger.Warn($"Невалидно време: StartTime={session.StartTime}, EndTime={session.EndTime}");
                throw new Exception("End time must be after start time.");
            }
            if (session.StartTime < DateTime.Now)
            {
                _logger.Warn($"Опит за добавяне на сесия в миналото: StartTime={session.StartTime}");
                throw new Exception("Start time cannot be in the past.");
            }

            await _sessionRepo.AddAsync(session);
            _logger.Info($"Сесията е добавена успешно за треньор Id={session.TrainerId}");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при добавяне на сесия за треньор Id={session?.TrainerId}", ex);
            throw;
        }
    }

    public async Task DeleteSessionAsync(int sessionId)
    {
        try
        {
            _logger.Info($"Изтриване на сесия Id={sessionId}");

            var session = await _sessionRepo.GetByIdAsync(sessionId);
            if (session == null)
            {
                _logger.Warn($"Не е намерена сесия Id={sessionId} за изтриване");
                throw new Exception("Session not found.");
            }

            await _sessionRepo.DeleteAsync(session);
            _logger.Info($"Сесия Id={sessionId} е изтрита успешно");
        }
        catch (Exception ex)
        {
            _logger.Error($"Грешка при изтриване на сесия Id={sessionId}", ex);
            throw;
        }
    }
}