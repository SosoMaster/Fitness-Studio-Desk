using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS.DTO
{
    public class AdminProgressDTO
    {
        public int ProgressId { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            return $"ProgressId: {ProgressId} Height: {Height} Weight: {Weight} ";
        }
    }
}
