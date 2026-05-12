using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;

namespace FitnessStudioApp.SERVICES
{
    public class TrainerRegisterService
    {
        private readonly TrainerRepository _trainerRepo;

        public TrainerRegisterService(TrainerRepository trainerRepo)
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