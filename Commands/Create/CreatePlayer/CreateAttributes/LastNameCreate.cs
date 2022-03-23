using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreatePlayer.CreateAttributes
{
    public class LastNameCreate
    {
        /// <summary>
        /// Read the file with all the last name located at FootballManager\bin\Debug\net6.0\Create and make it into a list
        /// </summary>
        public static string[] lastNames = File.ReadAllLines(@"Create\CreatePlayer\LastName.txt");

        /// <summary>
        /// picks a random number and returns the last name from the list of last names
        /// </summary>
        /// <returns> one last name from the list </returns>
        public static string CreateLastNameOfPlayer()
        {
            Random random = new Random();
            return lastNames[random.Next(0, lastNames.Length - 1)];
        }
    }
}
