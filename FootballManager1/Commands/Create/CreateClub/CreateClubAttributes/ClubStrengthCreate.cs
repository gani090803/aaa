using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Commands.Create.CreateClub.CreateClubAttributes
{
    public class ClubStrengthCreate
    {
        /// <summary>
        /// calculate the strength of a club
        /// </summary>
        /// <param name="squad"> the squad of the given club </param>
        /// <returns> the calculated club strength</returns>
        public static double CreateClubStrength(Squad squad)
        {
            double clubStrength = 0;
            ///<summary>
            /// goes through every starting eleven player in the squad and sum their ratings
            /// </summary>
            foreach(var player in squad.StartingEleven.Players)
            {
                clubStrength = clubStrength + player.Rating;
            }
            ///<summary>
            /// returns the sum of rating devided by eleven
            /// </summary>
            return clubStrength / 11;
        }
    }
}
