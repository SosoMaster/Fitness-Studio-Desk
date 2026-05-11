using FitnessStudioApp.MODELS;
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

    Task<List<Progress>> GetAllProgressToClient(int clientId);

    // трябва навярно да променим servicesите защото в момента нямат логкиа спрямо това а то трянва да е така.
    // трябва servicea CalculateBodyFat да стане CalculateProgress и да има логика за качване на мускулна маса, сваляне на килограми и качване на килограми.
}
