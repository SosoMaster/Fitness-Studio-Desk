using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<bool> HasActiveMembershipAsync(int clientId);
    }
}
