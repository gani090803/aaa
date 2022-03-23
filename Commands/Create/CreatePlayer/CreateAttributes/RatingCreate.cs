using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreatePlayer.CreateAttributes
{
    public class RatingCreate
    {
        public static int CreateRatingOfPlayer()
        {
            Random random = new Random();
            return random.Next(65, 75);
        }
    }
}
