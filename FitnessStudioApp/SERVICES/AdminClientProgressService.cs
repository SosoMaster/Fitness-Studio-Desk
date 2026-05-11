using FitnessStudioApp.MODELS;
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
        public async Task<List<Progress>> GetAllProgressToClient(int clientId)
        {
            return await _progressRepository.GetAllProgressToClient(clientId);
        }
    }
}
