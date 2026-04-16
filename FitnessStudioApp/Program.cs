using FitnessStudioApp.FORMS;
using FitnessStudioApp.MODELS;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new RegisterForm());

            using (var db = new FitnessStudioAppDbContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}