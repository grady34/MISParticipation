using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many exam scores do you have?");
            int numofscores = Convert.ToInt32(Console.ReadLine());
            List<double> scores = new List<double>();
            Dictionary<int, int> dictscores = new Dictionary<int, int>();
            //use a dictionary to setup a way to count the mode. then relate the id's back to the original numbers. The id's should have the same value as the indexes. 
            double average = 0;
            double min = 0;
            double max = 0;
            double mode = 0;
            int modenum = 0;

            for (int i = 0; i < numofscores; i++)
            {
                Console.WriteLine("Enter an exam score.");
                double examscores = Convert.ToDouble(Console.ReadLine());
                scores.Add(examscores);
            }

            for (int i = 1; i < numofscores; i++)
            {
                
                average = average + scores[i];
                if (scores[i] < scores[i-1])
                {
                    min = scores[i];
                }
                if (scores[i] > scores[i-1])
                {
                    max = scores[i];
                }
            }
            average = average / numofscores;
            Console.WriteLine($"The average of your exam scores is {Math.Round(average, 2)}.");
            Console.WriteLine($"The minimum of your exam scores is {min}.");
            Console.WriteLine($"The maximum of your exam scores is {max}.");
            Console.WriteLine($"The mode of your exam scores is {mode}.");
        }
    }
}
