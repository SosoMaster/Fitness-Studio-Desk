using FitnessStudioApp.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES
{
    public class ClientRegisterService
    {
        public ClientRegisterService() 
        {

        }
        
        public string Gender( RadioButton RdbMale, RadioButton RdbFemale)
        {
            string gender = string.Empty;

            if (RdbMale.Checked)
            {
                gender = "Male";
            }
            else if (RdbFemale.Checked)
            {
                gender = "Female";
            }
            return gender;
        }
    }

}
