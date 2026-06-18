using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Interfaces;

public interface IProgressRepository : IRepository<Progress>
{
    Task GainWeight();
    Task LoseWeight();
    Task GainMuscle();

    Task<List<AdminProgressDTO>> GetAllProgressToClient(int clientId);

    Task<Progress> GetProgressByClientId(int clientId);

    
}
