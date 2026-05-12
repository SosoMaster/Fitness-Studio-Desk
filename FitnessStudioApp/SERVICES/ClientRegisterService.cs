using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.Enums;
using FitnessStudioApp.REPOSITORY.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES
{
    public class ClientRegisterService
    {
        private readonly ClientRepository _clientRepo;

        public ClientRegisterService(ClientRepository clientRepo)
        {
            _clientRepo = clientRepo;
        }

   
        public string Gender(RadioButton rdbMale, RadioButton rdbFemale)
        {
            if (rdbMale.Checked) return "Male";
            if (rdbFemale.Checked) return "Female";
            throw new Exception("Please select a gender.");
        }

      
        public async Task RegisterClientAsync(Client client)
        {
            // Basic validation
            if (client.Age <= 0 || client.Age > 120)
                throw new Exception("Please enter a valid age (1-120).");
            if (client.Height <= 0)
                throw new Exception("Please enter a valid height.");
            if (client.Weight <= 0)
                throw new Exception("Please enter a valid weight.");
            if (string.IsNullOrEmpty(client.Gender))
                throw new Exception("Please select a gender.");

           
            client.MembershipStatus = MembershipStatus.Inactive;

            await _clientRepo.AddAsync(client);
        }
            
    }
}
