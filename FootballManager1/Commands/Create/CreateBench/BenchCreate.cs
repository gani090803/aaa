using Commands.Create.CreatePlayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreateBench
{
    public class BenchCreate
    {
        /// <summary>
        /// Read the file with all the bench position numbers
        /// located at FootballManager\bin\Debug\net6.0\Create and make it into a list
        /// </summary>
        public static string[] benchPositionNumber = File.ReadAllLines(@"Create\CreateBench\Bench.txt");

        /// <summary>
        /// creates a bench
        /// </summary>
        /// <returns> the bench created </returns>
        public static Bench CreateBench()
        {
            ///<summary>
            /// create a bench to fill with players and then return
            /// </summary>
            Bench bench = new Bench();
            ///<summary>
            /// creates 11 players for their coresponding positions
            /// </summary>
            bench.Players = new List<Player>();
            for (int i = 0; i < 7; i++)
            {
                bench.Players.Add(PlayerByPositionCreate.CreatePlayerByPosition(int.Parse(benchPositionNumber[i])));
            }

            return bench;
        }
    }
}
