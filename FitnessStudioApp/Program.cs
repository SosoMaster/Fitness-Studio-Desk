using FitnessStudioApp.FORMS;
using FitnessStudioApp.MODELS;
using FitnessStudioApp.MODELS.Enums;
using FitnessStudioApp.REPOSITORY.Classes;
using FitnessStudioApp.REPOSITORY.Interfaces;
using FitnessStudioApp.SERVICES;

namespace FitnessStudioApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           using FitnessStudioAppDbContext dbContext = new FitnessStudioAppDbContext();
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            User user = new User();
            UserRepository userRepository = new UserRepository(dbContext);
            UserService userService = new UserService(userRepository);
            ClientRepository clientRepository = new ClientRepository(dbContext);
            ClientRegisterService clientRegisterService = new ClientRegisterService();
            ClientRegisterForm clientRegisterForm = new ClientRegisterForm(user.UserId, clientRegisterService);
            ClientService clientService = new ClientService(clientRepository);
            TrainerRepository trainerRepository = new TrainerRepository(dbContext);
            TrainerService trainerService = new TrainerService(userService, trainerRepository);
            AdminRepository adminRepository = new AdminRepository(dbContext);
            AdminService adminService = new AdminService(userService,adminRepository);
            ProgressRepository progressRepository = new ProgressRepository(dbContext);
            AdminClientProgressService adminClientProgressService = new AdminClientProgressService(progressRepository);

            RegisterService registerService = new RegisterService(userService, userRepository, clientRepository, trainerRepository, adminRepository);

            LoginService loginService = new LoginService(userRepository);

            Application.Run(new AdminUsersForm(userService, clientService, trainerService, adminClientProgressService));



            /* Application.Run(new RegisterForm(registerService, clientRegisterService));*/

            /*  Application.Run(new ClientForm());*/

            /*Application.Run(new LoginForm(loginService));*/


            using (var db = new FitnessStudioAppDbContext())
            {
                db.Database.EnsureCreated();
            }

           



        }
    }
}