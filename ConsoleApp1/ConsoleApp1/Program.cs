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
            Dictionary<double, double> dictscores = new Dictionary<double, double>();
            double average = 0;
            double min = 0;
            double max = 0;
            double mode = 0;
            double modenum = 0;

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
            foreach (var item in scores)
            {
                if (dictscores.ContainsKey(item))
                {
                    dictscores[item]++;
                }
                else
                {
                    dictscores.Add(item, 1);
                }
            }
            foreach (KeyValuePair<double, double> number in dictscores)
            {
                if (number.Value > modenum )
                {
                    mode = number.Key;
                    modenum = number.Value;
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
