using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS;

public class TrainingSession
{
    public int TrainingSessionId { get; set; }
    public int TrainerId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int Capacity { get; set; }
    public string Description { get; set; }

    public Trainer Trainer { get; set; }

    public List<Booking> Bookings { get; set; } = new List<Booking>();
}
