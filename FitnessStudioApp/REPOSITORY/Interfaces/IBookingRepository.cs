using FitnessStudioApp.MODELS;

namespace FitnessStudioApp.REPOSITORY.Interfaces
{
    public interface IBookingRepository : IRepository<Booking>
    {
        Task<IEnumerable<Booking>> GetBookingsByTrainerIdAsync(int trainerId);
    }
}