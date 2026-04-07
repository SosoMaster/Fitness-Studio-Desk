using FitnessStudioApp.MODELS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS;

public class Trainer
{
    public int TrainerId {  get; set; }
    public Specialty Specialty { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }


}
