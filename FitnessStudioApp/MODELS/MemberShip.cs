using FitnessStudioApp.MODELS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS
{
    public class Membership
    {
        public int MembershipId { get; set; }  
        public int ClientId { get; set; }      
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MembershipStatus MembershipStatus { get; set; }

        public Client Client { get; set; }
    }
}
