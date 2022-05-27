/* 
The Player class stores and updates the player's points and whether the player will play again
*/

using System;

namespace Hilo
{
    public class Player
    {
        public int points = 300;
        public bool keepPlaying = true;

        //Determines if player will continue game
        public void SetKeepPlaying()
        {
            if (points > 0)
            {
                string input;
                do
                {
                    Console.WriteLine("Play again? [y/n] > ");
                    input = Console.ReadLine();
                    if (input != "y" && input != "n")
                        Console.WriteLine("Not a valid input. Try again");
                } while (input != "y" && input != "n");

                if (input == "n")    
                    keepPlaying = false;            
            }

            else
                keepPlaying = false;
        }

        //updates player's points based on the correctness of their guess
        public void UpdatePoints(bool correctGuess)
        {
            if (correctGuess)
                points += 100;
            else
                points -= 75;
        }
    }
}
