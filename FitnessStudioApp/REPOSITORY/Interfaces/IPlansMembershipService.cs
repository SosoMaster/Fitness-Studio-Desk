using FitnessStudioApp.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Interfaces;

public interface IPlansMembershipService
{
    Task<IEnumerable<Membership>> GetAllMembershipsAsync();
    Task<Membership> GetMembershipByIdAsync(int id);
    Task CreateMembershipAsync(Membership membership);
    Task UpdateMembershipAsync(Membership membership);
    Task DeleteMembershipAsync(int id);
    Task AssignMembershipToClientAsync(int membershipId, int clientId);
}
