using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;

namespace FitnessStudioApp.SERVICES
{
    public class TrainerRegisterService
    {
        private readonly ITrainerRepository _trainerRepo;

        public TrainerRegisterService(ITrainerRepository trainerRepo)
        {
            _trainerRepo = trainerRepo;
        }

        public async Task RegisterTrainerAsync(Trainer trainer)
        {
            if (trainer.UserId <= 0)
                throw new Exception("Invalid user reference.");

            await _trainerRepo.AddAsync(trainer);
        }
    }
}