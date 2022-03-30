using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreatePlayer.CreateAttributes
{
    public class AgeCreate
    {
        public static int CreateAgeOfPlayer()
        {
            Random random = new Random();
            return random.Next(18, 25);
        }
    }
}
