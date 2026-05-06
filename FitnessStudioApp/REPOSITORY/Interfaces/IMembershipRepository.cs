using FitnessStudioApp.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Interfaces;

public interface IMembershipRepository : IRepository<Membership>
{
    Task RenewMembership(int userId);
    Task<Membership> ViewMembership(int userId);
    Task EndMembership(int userId); // не знам дали ще е нужно да има параметър, но за сега ще го оставя така
}
