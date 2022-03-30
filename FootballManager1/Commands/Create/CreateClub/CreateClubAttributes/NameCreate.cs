using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreateClub.CreateClubAttributes
{
    public class NameCreate
    {
        /// <summary>
        /// Read the file with all the club name located at FootballManager\bin\Debug\net6.0\Create and make it into a list
        /// </summary>
        public static string[] clubNames = File.ReadAllLines(@"Create\CreateClub\ClubName.txt");

        /// <summary>
        /// returns the club name from the list of club names
        /// </summary>
        /// <param name="clubNumber"> the number of the club</param>
        /// <returns> club name from the list </returns>
        public static string CreateClubName(int clubNumber)
        {
            Random random = new Random();
            return clubNames[clubNumber];
        }
    }
}
