using Commands.Create.CreateBench;
using Commands.Create.CreateClub.CreateClubAttributes;
using Commands.Create.CreateReserves;
using Commands.Create.CreateStartingEleven;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreateClub
{
    public class ClubCreate
    {
        /// <summary>
        /// creates a the club with the given club number
        /// </summary>
        /// <param name="clubNumber"> the number of the club </param>
        /// <returns> the wanted club </returns>
        public static Club CreateClub(int clubNumber)
        {
            Club club = new Club();
            StartingEleven startingEleven = StartingElevenCreate.CreateStartingEleven();
            Bench bench = BenchCreate.CreateBench();
            Reserves reserves = ReservesCreate.CreateReserves();
            Squad squad = new Squad();

            squad.StartingEleven = startingEleven;
            squad.Bench = bench;
            squad.Reserves = reserves;

            club.Squad = squad;
            club.ClubName = NameCreate.CreateClubName(clubNumber);
            club.ClubStrength = ClubStrengthCreate.CreateClubStrength(club.Squad);

            return club;
        }
    }
}
