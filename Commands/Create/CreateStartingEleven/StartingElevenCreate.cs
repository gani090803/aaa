using Commands.Create.CreatePlayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreateStartingEleven
{
    public class StartingElevenCreate
    {
        /// <summary>
        /// Read the file with all the starting eleven position numbers
        /// located at FootballManager\bin\Debug\net6.0\Create and make it into a list
        /// </summary>
        public static string[] startingElevenPositionNumber = File.ReadAllLines(@"Create\CreateStartingEleven\StartingEleven.txt");

        /// <summary>
        /// creates a starting eleven
        /// </summary>
        /// <returns> the starting eleven created </returns>
        public static StartingEleven CreateStartingEleven()
        {
            ///<summary>
            /// create a starting eleven to fill with players and then return
            /// </summary>
            StartingEleven startingEleven = new StartingEleven();
            ///<summary>
            /// creates 11 players for their coresponding positions
            /// </summary>
            startingEleven.Players = new List<Player>();
            for(int i = 0; i < 11; i++)
            {
                startingEleven.Players.Add(PlayerByPositionCreate.CreatePlayerByPosition(int.Parse(startingElevenPositionNumber[i])));
            }

            return startingEleven;
        }
    }
}
