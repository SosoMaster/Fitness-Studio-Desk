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
    public class AdminTrainerService
    {
        readonly ClientRepository _clientRepository;
        public AdminTrainerService(ClientRepository clientRepository) 
        {
            _clientRepository = clientRepository;
        }

        public async Task<List<ClientAndTrainerDTO>> GetAllCklinetsToTrainer(int trainerId)
        {
           return await _clientRepository.GetAllCklinetsToTrainer(trainerId);
        }
    }
}
