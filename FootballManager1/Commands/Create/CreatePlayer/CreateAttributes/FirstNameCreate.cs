using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Commands.Create.CreatePlayer.CreateAttributes
{
    public static class FirstNameCreate
    {
        /// <summary>
        /// Read the file with all the first name located at FootballManager\bin\Debug\net6.0\Create and make it into a list
        /// </summary>
        public static string[] firstNames = File.ReadAllLines(@"Create\CreatePlayer\FirstName.txt");

        /// <summary>
        /// picks a random number and returns the first name from the list of first names
        /// </summary>
        /// <returns> one first name from the list </returns>
        public static string CreateFirstNameOfPlayer()
        {
            Random random = new Random();
            return firstNames[random.Next(0, firstNames.Length - 1)];
        }
    }
}
