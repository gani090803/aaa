using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commands.Create.CreatePlayer.CreateDifferentPosition;

namespace Commands.Create.CreatePlayer.CreateAttributes
{
    public class PositionCreate
    {
        /// <summary>
        /// create a random position for a player
        /// </summary>
        /// <returns> the random position and its subpositions </returns>
        public static string[] CreateRandomPosition()
        {
            ///<summary>
            /// create a random for the position randomizing
            /// </summary>
            Random random = new Random();
            ///<summary>
            /// depending on the random number call the method for the coresponding position
            /// and return that position and its subpositions
            /// </summary>
            switch (random.Next(1, 10))
            {
                case 1:
                    return GKCreate.CreatePositionGK();
                case 2:
                    return LBCreate.CreatePositionLB();
                case 3:
                    return CBCreate.CreatePositionCB();
                case 4:
                    return RBCreate.CreatePositionRB();
                case 5:
                    return CDMCreate.CreatePositionCDM();
                case 6:
                    return CMCreate.CreatePositionCM();
                case 7:
                    return CAMCreate.CreatePositionCAM();
                case 8:
                    return LWCreate.CreatePositionLW();
                case 9:
                    return STCreate.CreatePositionST();
                default:
                    return RWCreate.CreatePositionRW();
            }
        }

        /// <summary>
        /// create a position by requested
        /// </summary>
        /// <param name="positionNumber"> the number of the position wanted </param>
        /// <returns> the wanted position </returns>
        public static string[] CreatePosition(int positionNumber)
        {
            switch (positionNumber)
            {
                case 1:
                    return GKCreate.CreatePositionGK();
                case 2:
                    return LBCreate.CreatePositionLB();
                case 3:
                    return CBCreate.CreatePositionCB();
                case 4:
                    return RBCreate.CreatePositionRB();
                case 5:
                    return CDMCreate.CreatePositionCDM();
                case 6:
                    return CMCreate.CreatePositionCM();
                case 7:
                    return CAMCreate.CreatePositionCAM();
                case 8:
                    return LWCreate.CreatePositionLW();
                case 9:
                    return STCreate.CreatePositionST();
                default:
                    return RWCreate.CreatePositionRW();
            }
        }
    }
}
