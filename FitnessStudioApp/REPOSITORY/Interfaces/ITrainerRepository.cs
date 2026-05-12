using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Interfaces;

public interface ITrainerRepository: IRepository<Trainer>
{
    Task<IEnumerable<ClientAndTrainerDTO>> GetAddTrainerWithUserInfo();

    Task<Trainer> GetClientByUserId(int userId);
}
