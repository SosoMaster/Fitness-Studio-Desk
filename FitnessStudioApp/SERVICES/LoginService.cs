using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES
{
    public class LoginService 
    {
        private readonly UserRepository _userRepo;

        public LoginService (UserRepository userRepository)
        {
            _userRepo = userRepository;
        }
        
        public async Task<User> LoginAsync(string username, string password)
        {
            var user = await _userRepo.GetByUsernameAsync(username);
            if(user == null)
            {
                throw new Exception("User not found");
            }

            if(user.Password != password)
            {
                throw new Exception("Invalid password");
            }

            return user;
        }

    }
}
