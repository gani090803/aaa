using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreatePlayer.CreateDifferentPosition
{
    public class GKCreate
    {
        /// <summary>
        /// create an array to store the different positions
        /// </summary>
        static string[] position = new string[3];

        /// <summary>
        /// create a GK
        /// </summary>
        /// <returns> positions of a GK </returns>
        public static string[] CreatePositionGK()
        {
            position[0] = "GK";
            position[1] = "";
            position[2] = "";
            return position;
        }
    }
}
