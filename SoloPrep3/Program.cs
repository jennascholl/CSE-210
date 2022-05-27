using System;

namespace SoloPrep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 101);
            int guess = 0;
            do{
                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess > magicNum)
                    Console.WriteLine("Too high!");
                if (guess < magicNum)
                    Console.WriteLine("Too low!");
            } while (guess != magicNum);
            Console.WriteLine("You guessed it!");
        }
    }
}
