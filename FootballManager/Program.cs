using Microsoft.EntityFrameworkCore;
using Models;
using Commands.Create.CreatePlayer;
using Commands.Create.CreatePlayer.CreateAttributes;
using Commands.Create.CreateStartingEleven;
using Commands.Create.CreateClub;

namespace FootballManager
{
    internal static class Program
    {
        public static Random random = new Random();
        /// <summary>
        /// Create an object saveContext from Models
        /// </summary>
        public static SaveContext saveContext = new SaveContext();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary> 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            /// <summary>
            /// Migrate to Create the table if it is not created
            /// </summary>
            saveContext.Database.Migrate();
            /// <summary>
            /// we make a list that will contain every save from the Database
            /// </summary>
            Application.Run(new FootballManagerLoadGameMenu());           
        }
    }
}