using FitnessStudioApp.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES.Interfaces
{
    public interface IUserService
    {
        Task AddAsync(User entity);
    }
}
