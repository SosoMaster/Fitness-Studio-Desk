using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
     Task<IEnumerable<ClientAndTrainerDTO>> GetAddClientWithUserInfo();
        
    }
}
