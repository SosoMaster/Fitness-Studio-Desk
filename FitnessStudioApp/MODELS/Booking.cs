using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS
{
    public class Booking
    {
        public int BookingId { get; set; }         
        public int ClientId { get; set; }           
        public int TrainingSessionId { get; set; } 
        public string Status { get; set; }

       
        public Client Client { get; set; }
/*        public TrainingSession TrainingSession { get; set; }
*/    }
}
