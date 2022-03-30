using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Create.CreatePlayer.CreateAttributes
{
    public class ValueCreate
    {
        /// <summary>
        /// method to calculate the value of a player
        /// </summary>
        /// <param name="rating"> the rating of the player </param>
        /// <param name="potential"> the potential of the player </param>
        /// <param name="age"> the age of the player </param>
        /// <returns> the value of the player </returns>
        public static double CreateValueOfPlayer(int rating, int potential, int age)
        {
            ///<summary>
            /// create the initial value
            /// </summary>
            double value = 1800000;


            ///<summary>
            /// increase the value based on the rating of the player
            /// </summary>
            for(int i = 65; i < rating; i++)
            {
                value = value + (value * 2 / 5);
            }


            /// <summary>
            /// increase the value based on the potential
            /// </summary>
            if(potential >= 80 && potential <= 85)
            {
                value = value+ (value * 1 / 8);
            }
            if (potential >= 86 && potential <= 90)
            {
                value = value + (value * 1 / 6);
            }
            if (potential >= 90 && potential <= 95)
            {
                value = value + (value * 1 / 3);
            }
            if (potential >= 96 && potential <= 99)
            {
                value = value + (value * 5 / 6);
            }



            ///<summary>
            /// decrease the value based on the age
            /// </summary>
            if(age >= 28 && age <= 29)
            {
                value = value - (value * 1 / 18);
            }
            if (age >= 30 && age <= 31)
            {
                value = value - (value * 1 / 9);
            }
            if (age >= 32 && age <= 33)
            {
                value = value - (value * 1 / 6);
            }
            if (age >= 34 && age <= 35)
            {
                value = value - (value * 5 / 18);
            }
            if (age >35)
            {
                value = value - (value * 1 / 6);
            }



            ///<summary>
            /// return the calculated value
            /// </summary>
            return value;
        }
    }
}
