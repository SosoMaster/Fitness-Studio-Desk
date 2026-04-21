using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS;

public class Client
{
    public int ClientId { get; set; }
    public string MembershipStatus { get; set; }

    public Trainer Trainer { get; set; }

    public int UserId { get; set; }
    public User User { get; set; } = null!;
}
