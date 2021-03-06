using Commands.Create.CreatePlayer.CreateAttributes;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreatePlayer
{
    public class PlayerByPositionCreate
    {
        /// <summary>
        /// create a player with given position number
        /// </summary>
        /// <param name="positionNumber"> the number of the position the player should play</param>
        /// <returns> player in the position given </returns>
        public static Player CreatePlayerByPosition(int positionNumber)
        {
            Player player = new Player();
            player.FirstName = FirstNameCreate.CreateFirstNameOfPlayer();
            player.LastName = LastNameCreate.CreateLastNameOfPlayer();
            player.Nation = NationCreate.CreateNationOfPlayer();
            player.Rating = RatingCreate.CreateRatingOfPlayer();
            player.Potential = PotentialCreate.CreatePotentialOfPlayer();
            player.Age = AgeCreate.CreateAgeOfPlayer();
            player.Stats = new Stats();
            player.Value = ValueCreate.CreateValueOfPlayer(player.Rating, player.Potential, player.Age);
            string[] positions = PositionCreate.CreatePosition(positionNumber);
            if (positions[1] == null) positions[1] = " ";
            if (positions[2] == null) positions[2] = " ";
            player.Position1 = positions[0];
            player.Position2 = positions[1];
            player.Position3 = positions[2];

            return player;
        }
    }
}
