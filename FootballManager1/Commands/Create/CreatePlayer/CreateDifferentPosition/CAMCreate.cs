using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreatePlayer.CreateDifferentPosition
{
    public class CAMCreate
    {
        /// <summary>
        /// create a random to use for the creation of positions
        /// </summary>
        static Random random = new Random();



        /// <summary>
        /// create a LB
        /// </summary>
        /// <returns> positions of the CAM </returns>
        public static string[] CreatePositionCAM()
        {
            List<string> possiblePositions = new List<string> { "CAM", "CM", "LW", "ST", "RW" };
            string[] position = new string[3];
            ///<summary>
            /// give the initial position
            /// </summary>
            position[0] = possiblePositions[0];

            ///<summary>
            /// possibility for a scond position
            /// </summary>
            if (random.Next(1, 4) == 1)
            {
                ///<summary>
                /// give the second position
                /// </summary>
                int r = random.Next(1, 5);
                position[1] = possiblePositions[r];
                possiblePositions.Remove(possiblePositions[r]);

                ///<summary>
                /// possibility for a third position
                /// </summary>
                if (random.Next(1, 4) == 1)
                {
                    ///<summary>
                    /// give the third position
                    /// </summary>
                    int r2 = random.Next(1, 4);
                    position[2] = possiblePositions[r2];
                    possiblePositions.Remove(possiblePositions[r2]);
                }
            }


            return position;
        }
    }
}