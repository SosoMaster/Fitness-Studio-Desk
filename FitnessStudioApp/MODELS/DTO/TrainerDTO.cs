using FitnessStudioApp.MODELS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS.DTO;

public class TrainerDTO
{
    public string Name { get; set; }
    public Specialty Specialty { get; set; }

    public override string ToString()
    {
        return $"{Name} {Specialty}";
    }
}
