using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY.Classes;

public class MembershipRepository : BaseRepository<Membership>, IMembershipRepository
{
    public MembershipRepository(FitnessStudioAppDbContext db) : base(db)
    {
    }

    public void RenewMembership()
    {
        // implement domain-specific logic as needed
        throw new NotImplementedException();
    }

    public void ViewMembership(string userId)
    {
        throw new NotImplementedException();
    }

    public void EndMembership(string userId)
    {
        throw new NotImplementedException();
    }
}
