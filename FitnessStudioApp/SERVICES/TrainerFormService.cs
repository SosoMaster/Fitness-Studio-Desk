using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;

namespace FitnessStudioApp.SERVICES
{
    public class TrainerFormService
    {
        private readonly TrainerRepository _trainerRepo;
        private readonly TrainingSessionRepository _sessionRepo;
        private readonly BookingRepository _bookingRepo;

        public TrainerFormService(
            TrainerRepository trainerRepo,
            TrainingSessionRepository sessionRepo,
            BookingRepository bookingRepo)
        {
            _trainerRepo = trainerRepo;
            _sessionRepo = sessionRepo;
            _bookingRepo = bookingRepo;
        }


        public async Task<Trainer> GetTrainerByUserIdAsync(int userId)
        {
            var trainer = await _trainerRepo.GetClientByUserId(userId);
            if (trainer == null)
                throw new Exception("Trainer profile not found.");
            return trainer;
        }


        public async Task<IEnumerable<TrainingSession>> GetAllSessionsAsync(int trainerId)
        {
            return await _sessionRepo.GetSessionsByTrainerIdAsync(trainerId);
        }


        public async Task<IEnumerable<TrainingSession>> GetUpcomingSessionsAsync(int trainerId)
        {
            return await _sessionRepo.GetUpcomingSessionsByTrainerIdAsync(trainerId);
        }


        public async Task<IEnumerable<Booking>> GetAllBookingsAsync(int trainerId)
        {
            return await _bookingRepo.GetBookingsByTrainerIdAsync(trainerId);
        }


        public async Task AddSessionAsync(TrainingSession session)
        {
            if (string.IsNullOrWhiteSpace(session.Description))
                throw new Exception("Please enter a session description.");
            if (session.Capacity <= 0)
                throw new Exception("Capacity must be greater than 0.");
            if (session.EndTime <= session.StartTime)
                throw new Exception("End time must be after start time.");
            if (session.StartTime < DateTime.Now)
                throw new Exception("Start time cannot be in the past.");

            await _sessionRepo.AddAsync(session);
        }


        public async Task DeleteSessionAsync(int sessionId)
        {
            var session = await _sessionRepo.GetByIdAsync(sessionId);
            if (session == null)
                throw new Exception("Session not found.");

            await _sessionRepo.DeleteAsync(session);
        }
    }
}