using FitnessStudioApp.FORMS;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
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

        public RegisterService(
            UserService userService,
            UserRepository userRepo,
            AdminRepository adminRepo)
        {
            _userService = userService;
            _userRepo = userRepo;
            _adminRepo = adminRepo;
        }

        /// <summary>
        /// Creates the User row.
        /// Returns the saved User (with its new UserId) so the caller
        /// can open the correct role-specific form.
        /// </summary>
        public async Task<User> RegisterAsync(User user, string role)
        {
            // Validate fields
            UserValidator.InfoFieldsValidate(user);

            // Duplicate check
            var existing = await _userRepo.GetByUsernameAsync(user.Username);
            if (existing != null)
                throw new Exception("Username already exists.");

            if (role != "Client" && role != "Trainer" && role != "Admin")
                throw new Exception("Please select a valid role.");

            // Persist user — EF will populate UserId after SaveChanges
            await _userService.AddAsync(user);

            // For Admin, finish here (no extra profile form needed)
            if (role == "Admin")
            {
                Admin admin = new() { UserId = user.UserId };
                await _adminRepo.AddAsync(admin);
            }

            return user; // UserId is now set
        }
    }
}
