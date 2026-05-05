using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS.DTO;

public class ClientAndTrainerDTO
{
    public int UserId { get; set; }
    public int ModelId { get; set; }
    public string Name { get; set; }


    public override string ToString()
    {
        return $" UserId: {UserId} ClientId: {ModelId} Name: {Name}";
    }


}
