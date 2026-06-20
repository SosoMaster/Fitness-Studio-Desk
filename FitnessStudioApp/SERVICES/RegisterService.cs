using FitnessStudioApp.FORMS;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.REPOSITORY.Interfaces;
using FitnessStudioApp.SERVICES.Helpers;
using FitnessStudioApp.SERVICES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES
{
    //public class RegisterService
    //{
    //    private readonly UserService _userService;
    //    private readonly UserRepository _userRepo;
    //    private readonly AdminRepository _adminRepo;
    //    private UserService object1;
    //    private IUserRepository object2;
    //    private IAdminRepository object3;
    //    private IUserService iUserService;

    //    public RegisterService(
    //        UserService userService,
    //        UserRepository userRepo,
    //        AdminRepository adminRepo)
    //    {
    //        _userService = userService;
    //        _userRepo = userRepo;
    //        _adminRepo = adminRepo;
    //    }

    //    public RegisterService(UserService object1, IUserRepository object2, IAdminRepository object3)
    //    {
    //        this.object1 = object1;
    //        this.object2 = object2;
    //        this.object3 = object3;
    //    }
    //    public RegisterService(IUserService iUserService, IUserRepository object2, IAdminRepository object3)
    //    {
    //        this.iUserService = iUserService;
    //        this.object2 = object2;
    //        this.object3 = object3;
    //    }

    //    /// <summary>
    //    /// Creates the User row.
    //    /// Returns the saved User (with its new UserId) so the caller
    //    /// can open the correct role-specific form.
    //    /// </summary>
    //    public async Task<User> RegisterAsync(User user, string role)
    //    {
    //        UserValidator.InfoFieldsValidate(user);

    //        var existing = await _userRepo.GetByUsernameAsync(user.Username);
    //        if (existing != null)
    //            throw new Exception("Username already exists.");

    //        if (role != "Client" && role != "Trainer" && role != "Admin")
    //            throw new Exception("Please select a valid role.");

    //        await _userService.AddAsync(user);

    //        if (role == "Admin")
    //        {
    //            Admin admin = new() { UserId = user.UserId };
    //            await _adminRepo.AddAsync(admin);
    //        }

    //        return user; 
    //    }
    //}

    public class RegisterService
    {
        // 1. Maintain ONLY interface fields
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepo;
        private readonly IAdminRepository _adminRepo;

        // 2. Maintain EXACTLY ONE constructor that accepts interfaces
        public RegisterService(
            IUserService userService,
            IUserRepository userRepo,
            IAdminRepository adminRepo)
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
            UserValidator.InfoFieldsValidate(user);

            // This will now use your mocked interface repository seamlessly!
            var existing = await _userRepo.GetByUsernameAsync(user.Username);
            if (existing != null)
                throw new Exception("Username already exists.");

            if (role != "Client" && role != "Trainer" && role != "Admin")
                throw new Exception("Please select a valid role.");

            // This will now intercept via Moq and trigger your Callback (UserId = 3)
            await _userService.AddAsync(user);

            if (role == "Admin")
            {

                // Това е правено от Валери и е пълна простотия аз я бях (Сашо) направил като хората и сега е пълен shit
                // Това е правено от Валери и е пълна простотия аз я бях (Сашо) направил като хората и сега е пълен shit
                // Това е правено от Валери и е пълна простотия аз я бях (Сашо) направил като хората и сега е пълен shit

                Admin admin = new() { UserId = user.UserId };
                await _adminRepo.AddAsync(admin);
            }

            return user;
        }
    }

}

