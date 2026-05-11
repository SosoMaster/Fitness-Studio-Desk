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
        private readonly RegisterForm _registerForm;
        private readonly ClientRepository _clientRepo;
        private readonly ClientRegisterService _clientRegisterService;
        private readonly TrainerRepository _trainerRepo;
        private readonly AdminRepository _adminRepo;
        private readonly UserRepository _userRepo;

        public RegisterService(
            UserService userService,
            UserRepository userRepo,
            ClientRepository clientRepo,
            TrainerRepository trainerRepo,
            AdminRepository adminRepo)
        {
            _userService = userService;
            _userRepo = userRepo;
            _clientRepo = clientRepo;
            _trainerRepo = trainerRepo;
            _adminRepo = adminRepo;
        }

        public async Task RegisterAsync(User user, string role)
        {
            // validation
            UserValidator.InfoFieldsValidate(user);

            // duplicate check
            var existingUser =
                await _userRepo.GetByUsernameAsync(user.Username);

            if (existingUser != null)
            {
                throw new Exception("Username already exists");
            }

            // create user
            await _userService.AddAsync(user);

            // role assignment
            switch (role)
            {
                case "Client":
                    var clientForm = new ClientRegisterForm(user.UserId, _clientRegisterService);
                    clientForm.Show();
                    _registerForm.Hide();
                    break;

                case "Trainer":
                    Trainer trainer = new Trainer()
                    {
                        UserId = user.UserId
                    };

                    await _trainerRepo.AddAsync(trainer);
                    break;

                case "Admin":
                    Admin admin = new Admin()
                    {
                        UserId = user.UserId
                    };

                    await _adminRepo.AddAsync(admin);
                    break;

                default:
                    throw new Exception("Invalid role");
            }
        }
    }
}
