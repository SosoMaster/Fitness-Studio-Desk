using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS
{
    public class Progress
    {
        public int ProgressId { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public double Weight { get; set; }
        public int BodyFat { get; set; }
        public int Calories { get; set; }
        public string Notes { get; set; }
    }
}
