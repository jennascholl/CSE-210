using System;
using System.Collections.Generic;

namespace SoloPrep4
{
    class Program
    {
        static void Main(string[] args)
        {   
            //get numbers
            List<int> numList = new List<int>();
            int input = 1;
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            while (true) 
            {
                Console.WriteLine("Enter number: ");
                input = int.Parse(Console.ReadLine());
                if(input != 0)
                    numList.Add(input);
                else
                    break;
            }

            //do calculations
            int sum = 0;
            int avg;
            int count = 0;
            int highest = 0;
            foreach (int num in numList)
            {
                sum += num;
                count++;
                if (num > highest)
                    highest = num;
            }
            avg = sum / count;

            //display results
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + avg);
            Console.WriteLine("The largest number is: "+ highest);

        }
    }
}
