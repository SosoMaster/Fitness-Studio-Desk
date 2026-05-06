using FitnessStudioApp.MODELS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS;

public class Trainer
{
    public int TrainerId { get; set; }
    public Specialty Specialty { get; set; }
    public List<Client> Clients { get; set; } = new List<Client>();

    public int UserId { get; set; } 
    public User User { get; set; } = null!;
    public List<TrainingSession> TrainingSessions { get; set; } = new List<TrainingSession>();

}
