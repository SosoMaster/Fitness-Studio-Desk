using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS;

public class Progress
{
    public int ProgressId { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;
    public int Age { get; set; }
    public string Gender { get; set; }
    public int Height { get; set; }
    public double Weight { get; set; }
}

