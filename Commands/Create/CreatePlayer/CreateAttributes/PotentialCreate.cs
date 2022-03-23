using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreatePlayer.CreateAttributes
{
    public class PotentialCreate
    {
        public static int CreatePotentialOfPlayer()
        {
            Random random = new Random();
            return random.Next(75, 85);
        }
    }
}
