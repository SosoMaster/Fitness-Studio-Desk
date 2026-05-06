using FitnessStudioApp.FORMS;
using FitnessStudioApp.MODELS;
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

            UserRepository userRepository = new UserRepository(dbContext);
            UserService userService = new UserService(userRepository);
            ClientRepository clientRepository = new ClientRepository(dbContext);
            ClientService clientService = new ClientService(userService,clientRepository);
            TrainerRepository trainerRepository = new TrainerRepository(dbContext);
            TrainerService trainerService = new TrainerService(userService, trainerRepository);
            AdminRepository adminRepository = new AdminRepository(dbContext);
            AdminService adminService = new AdminService(userService,adminRepository);


            Application.Run(new AdminUsersForm(userService, clientService, trainerService));

    
            using (var db = new FitnessStudioAppDbContext())
            {
                db.Database.EnsureCreated();
            }



        }
    }
}