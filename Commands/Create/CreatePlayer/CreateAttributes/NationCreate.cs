using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreatePlayer.CreateAttributes
{
    public class NationCreate
    {
        /// <summary>
        /// Read the file with all the nation located at FootballManager\bin\Debug\net6.0\Create and make it into a list
        /// </summary>
        public static string[] nation = File.ReadAllLines(@"Create\CreatePlayer\Nation.txt");

        /// <summary>
        /// picks a random number and returns the nation from the list of nations
        /// </summary>
        /// <returns> one nation from the list </returns>
        public static string CreateNationOfPlayer()
        {
            Random random = new Random();
            return nation[random.Next(0, nation.Length - 1)];
        }
    }
}
