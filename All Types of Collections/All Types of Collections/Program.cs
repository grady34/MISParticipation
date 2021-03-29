using System;
using System.Collections.Generic;

namespace All_Types_of_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            string[] courseSubject = new string[3];
            string[] courseNum = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a course subject");
                courseSubject[i] = Console.ReadLine();
                Console.WriteLine("Enter a course number");
                courseNum[i] = Console.ReadLine();
            }
            
            Console.WriteLine("Your results are ...");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{courseSubject[i]}{courseNum[i]}");
            }
            

            //Problem 2
            string ans;
            List<double> grades = new List<double>();
            do
            {
                Console.WriteLine("Enter a grade.");
                double grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);
                Console.WriteLine("Would you like to input another grade? (yes/no)");
                ans = Console.ReadLine();
                
            } while (ans.ToLower() == "yes");

            double sum = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                sum = grades[i] + sum;
            }
            double avg = sum / grades.Count;
            Console.WriteLine($"Your average grade is {avg}%");
            
            //Problem 3
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(0.95);
            courseGrades["MIS3013"].Add(0.87);
            courseGrades["MIS3013"].Add(0.90);
            courseGrades.Add("MIS3383", new List<double>());
            courseGrades["MIS3383"].Add(0.78);
            courseGrades["MIS3383"].Add(0.87);
            courseGrades["MIS3383"].Add(0.93);
            courseGrades.Add("MIS3033", new List<double>());
            courseGrades["MIS3033"].Add(0.90);
            courseGrades["MIS3033"].Add(0.80);
            courseGrades["MIS3033"].Add(0.86);

            
            foreach (var courseSub in courseGrades.Keys)
            {
                double add = 0;
                foreach (var courseNums in courseGrades[courseSub])
                {
                    add = courseNums + add;
                }
                double avg2 = (add*100) / 3;
                Console.WriteLine($"The average of {courseSub} is {avg2}%");
            }

            
        }
    }
}
