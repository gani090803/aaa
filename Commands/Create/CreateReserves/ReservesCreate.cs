using Commands.Create.CreatePlayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreateReserves
{
    public class ReservesCreate
    {
        /// <summary>
        /// creates a reserves
        /// </summary>
        /// <returns> the reserves created </returns>
        public static Reserves CreateReserves()
        {
            ///<summary>
            /// create a reserves to fill with players and then return
            /// </summary>
            Reserves reserves = new Reserves();
            reserves.Players = new List<Player>();
            ///<summary>
            /// creates 5 players
            /// </summary>
            for (int i = 0; i < 5; i++)
            {
                reserves.Players.Add(RandomPositionPlayerCreate.CreateRandomPositionPlayer());
            }
            return new Reserves();
        }
    }
}
