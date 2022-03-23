using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreatePlayer.CreateDifferentPosition
{
    public class CDMCreate
    {
        /// <summary>
        /// create an array to store the different positions
        /// </summary>
        static string[] position = new string[3];
        /// <summary>
        /// create a random to use for the creation of positions
        /// </summary>
        static Random random = new Random();
        /// <summary>
        /// create a list with all the possible values
        /// </summary>
        static List<string> possiblePositions = new List<string> { "CDM", "CM", "LB", "CB", "RB" };



        /// <summary>
        /// create a LB
        /// </summary>
        /// <returns> positions of the CDM </returns>
        public static string[] CreatePositionCDM()
        {
            possiblePositions = new List<string> { "CDM", "CM", "LB", "CB", "RB" };
            ///<summary>
            /// give the initial position
            /// </summary>
            position[0] = possiblePositions[0];

            ///<summary>
            /// possibility for a scond position
            /// </summary>
            if (random.Next(1, 3) == 1)
            {
                ///<summary>
                /// give the second position
                /// </summary>
                int r = random.Next(1, 4);
                position[1] = possiblePositions[r];
                possiblePositions.Remove(possiblePositions[r]);

                ///<summary>
                /// possibility for a third position
                /// </summary>
                if (random.Next(1, 3) == 1)
                {
                    ///<summary>
                    /// give the third position
                    /// </summary>
                    int r2 = random.Next(1, 3);
                    position[2] = possiblePositions[r2];
                    possiblePositions.Remove(possiblePositions[r2]);
                }
            }


            return position;
        }
    }
}