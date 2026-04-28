using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES
{
    public class TrainingSessionService
    {
        private readonly TrainingSessionRepository _sessionRepo;
        private readonly ClientRepository _clientRepo;
        private readonly TrainerRepository _trainerRepo;

        public TrainingSessionService(
            TrainingSessionRepository sessionRepo,
            ClientRepository clientRepo,
            TrainerRepository trainerRepo)
        {
            _sessionRepo = sessionRepo;
            _clientRepo = clientRepo;
            _trainerRepo = trainerRepo;
        }

        public async Task AddAsync(TrainingSession session)
        {
            if (session == null)
                throw new Exception("Session is null");

            var trainer = await _trainerRepo.GetByIdAsync(session.TrainerId);

            if (trainer == null)
                throw new Exception("Invalid trainer");

            await _sessionRepo.AddAsync(session);
        }

        public async Task Delete(TrainingSession entity)
        {
            if (entity == null)
                throw new Exception("Session is null");

            var existing = await _sessionRepo.GetByIdAsync(entity.TrainingSessionId);

            if (existing == null)
                throw new Exception("No session found");

            await _sessionRepo.DeleteAsync(existing);
        }

        public async Task<IEnumerable<TrainingSession>> GetAllAsync()
        {
            var sessions = await _sessionRepo.GetAllAsync();

            if (!sessions.Any())
                throw new Exception("No sessions found");

            return sessions;
        }

        public async Task<TrainingSession> GetByIdAsync(int id)
        {
            var session = await _sessionRepo.GetByIdAsync(id);

            if (session == null)
                throw new Exception("No session found");

            return session;
        }

        public async Task Update(TrainingSession entity)
        {
            if (entity == null)
                throw new Exception("Session is null");

            var existing = await _sessionRepo.GetByIdAsync(entity.TrainingSessionId);

            if (existing == null)
                throw new Exception("No session found");

            await _sessionRepo.UpdateAsync(entity);
        }
    }
}
