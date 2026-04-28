using FitnessStudioApp.MODELS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS;

public class Client
{
    public int ClientId { get; set; }
    public MembershipStatus MembershipStatus { get; set; }

    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int ProgressId { get; set; }
    public List<Progress> progresses { get; } = new List<Progress>();
    
    public Membership Membership { get; set; }
    public List<Booking> Bookings { get; set; } = new List<Booking>();
}
