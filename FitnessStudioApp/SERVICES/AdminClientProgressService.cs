using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.DTO;
using FitnessStudioApp.REPOSITORY.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES
{
    public class AdminClientProgressService
    {
        readonly ProgressRepository _progressRepository;

        public AdminClientProgressService(ProgressRepository progressRepository)
        {
            _progressRepository = progressRepository;
        }
        public async Task<List<AdminProgressDTO>> GetAllProgressToClient(int clientId)
        {
            return await _progressRepository.GetAllProgressToClient(clientId);
        }

        public async Task DeleteProgressAsync(Progress entity)
        {
            await _progressRepository.DeleteAsync(entity);
        }
        public async Task<Progress> GetProgressByClientId(int clientId)
        {
            return await _progressRepository.GetProgressByClientId(clientId);
        }

        public async Task<Progress> GetByIdAsync(int id)
        {
            return await _progressRepository.GetByIdAsync(id);
        }



    }
}
