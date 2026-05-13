using FitnessStudioApp.FORMS;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.REPOSITORY.Interfaces;
using FitnessStudioApp.SERVICES.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES
{
    public class RegisterService
    {
        private readonly UserService _userService;
        private readonly UserRepository _userRepo;
        private readonly AdminRepository _adminRepo;
        private UserService object1;
        private IUserRepository object2;
        private IAdminRepository object3;

        public RegisterService(
            UserService userService,
            UserRepository userRepo,
            AdminRepository adminRepo)
        {
            _userService = userService;
            _userRepo = userRepo;
            _adminRepo = adminRepo;
        }

        public RegisterService(UserService object1, IUserRepository object2, IAdminRepository object3)
        {
            this.object1 = object1;
            this.object2 = object2;
            this.object3 = object3;
        }

        /// <summary>
        /// Creates the User row.
        /// Returns the saved User (with its new UserId) so the caller
        /// can open the correct role-specific form.
        /// </summary>
        public async Task<User> RegisterAsync(User user, string role)
        {
            UserValidator.InfoFieldsValidate(user);

            var existing = await _userRepo.GetByUsernameAsync(user.Username);
            if (existing != null)
                throw new Exception("Username already exists.");

            if (role != "Client" && role != "Trainer" && role != "Admin")
                throw new Exception("Please select a valid role.");

            await _userService.AddAsync(user);

            if (role == "Admin")
            {
                Admin admin = new() { UserId = user.UserId };
                await _adminRepo.AddAsync(admin);
            }

            return user; 
        }
    }
}
