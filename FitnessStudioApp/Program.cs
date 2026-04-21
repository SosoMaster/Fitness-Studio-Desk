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
            UserRepository UserRepository = new UserRepository(dbContext);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            UserService userService = new UserService(UserRepository);
            Application.Run(new RegisterForm(userService));
            //

            //var db = new FitnessStudioAppDbContext();
            //var userRepo = new UserRepository(db);
            //_loginService = new LoginService(userRepo);
            //
            //
            using (var db = new FitnessStudioAppDbContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}