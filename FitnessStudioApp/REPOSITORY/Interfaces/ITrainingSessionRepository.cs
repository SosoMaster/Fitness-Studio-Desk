using FitnessStudioApp.MODELS;

namespace FitnessStudioApp.REPOSITORY.Interfaces
{
    public interface ITrainingSessionRepository : IRepository<TrainingSession>
    {
        Task<IEnumerable<TrainingSession>> GetSessionsByTrainerIdAsync(int trainerId);
        Task<IEnumerable<TrainingSession>> GetUpcomingSessionsByTrainerIdAsync(int trainerId);
    }
}