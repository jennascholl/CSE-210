using System;

namespace SoloPrep2
{
    class Program
    {
        static void Main(string[] args)
        {
            //get percent
            Console.WriteLine("What is your grade percentage? ");
            string input = Console.ReadLine();
            int percent = int.Parse(input);

            //find letter grade
            string letterGrade;
            if (percent >= 90)
            {
                letterGrade = "A";
            }
            else if (percent >= 80)
            {   
                letterGrade = "B";
            }
            else if (percent >= 70)
            {
                letterGrade = "C";
            }
            else if (percent >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            Console.WriteLine($"Your letter grade is: {letterGrade}");

            //pass or fail
            if (percent >= 70)
            {
                Console.WriteLine("Congratulations! You passed the class!");
            }
            else
                Console.WriteLine("Stay focused and you'll get it next time!");
        }
    }
}
