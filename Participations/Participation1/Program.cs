using System;

namespace Participation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter another number");
            string number2 = Console.ReadLine();
            Console.WriteLine("Enter one more number");
            string number3 = Console.ReadLine();

            double result1;
            double result2;
            double result3;

            result1 = Convert.ToDouble(number1);
            result2 = Convert.ToDouble(number2);
            result3 = Convert.ToDouble(number3);

            double output1 = result1 + result2 + result3;
            Console.WriteLine("The sum of the numbers you entered is " + Math.Round(output1, 3));

            const double MAGIC_NUMBER = 7.777; // local variable that is a constant

            double output2 = Math.Round(output1, 3) * MAGIC_NUMBER;
            Console.WriteLine("The product of 7.777 and the sum of the three numbers is " + Math.Round(output2, 3));


        }
    }
}
