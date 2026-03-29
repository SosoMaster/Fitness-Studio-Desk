using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS;

public class Client
{
    public int ClientId { get; set; }
    public int UsertId { get; set; }
    public int TrainerId { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public bool MembershipStatus { get; set; }


}
