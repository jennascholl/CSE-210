/* 
The Card class randomly selects the number of the card
 */
using System;

namespace Hilo
{
    public class Card
    {
        public int number;

        public void SetNumber()
        {
            Random rand = new Random();
            number = rand.Next(1, 14);
        }
    }
}
