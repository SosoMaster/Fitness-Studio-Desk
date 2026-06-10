using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES
{
    public class PlansMembershipService : IPlansMembershipService
    {
        private readonly MembershipRepository _membershipRepo;

        public PlansMembershipService(MembershipRepository membershipRepo)
        {
            _membershipRepo = membershipRepo;
        }

        public async Task AssignMembershipToClientAsync(int membershipId, int clientId)
        {
            var membership = await _membershipRepo.GetByIdAsync(membershipId);
            if (membership == null) throw new Exception("Membership not found");

            membership.ClientId = clientId;
            await _membershipRepo.UpdateAsync(membership);
        }

        public async Task CreateMembershipAsync(Membership membership)
        {
            if (membership == null)
            {
                throw new ArgumentNullException(nameof(membership));
            }

            await _membershipRepo.AddAsync(membership);
        }

        public async Task DeleteMembershipAsync(int id)
        {
            var membership = await _membershipRepo.GetByIdAsync(id);
            if (membership == null) throw new Exception("Membership not found");
            await _membershipRepo.DeleteAsync(membership);
        }

        public async Task<IEnumerable<Membership>> GetAllMembershipsAsync()
        {
            return await _membershipRepo.GetAllAsync();
        }

        public async Task<Membership> GetMembershipByIdAsync(int id)
        {
            var ms = await _membershipRepo.GetByIdAsync(id);
            if (ms == null) throw new Exception("Membership not found");
            return ms;
        }

        public async Task UpdateMembershipAsync(Membership membership)
        {
            if (membership == null) throw new ArgumentNullException(nameof(membership));
            await _membershipRepo.UpdateAsync(membership);
        }
    }
}
