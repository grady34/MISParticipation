using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Grady Allen", "MIS3033", "03/31/2021");
            string result = " ";
            double val1;
            double val2;
            double ans = 0;
            do
            {
                if (result == "previous")
                {
                    val1 = ans;
                    Console.WriteLine("Enter a second value.");
                    val2 = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Enter a value.");
                    val1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter a second value.");
                    val2 = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("What would you like to do. Add, Subtract, Multiply, or Divide?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "add")
                {
                    ans = Add(val1, val2);
                }
                else if (answer == "subtract")
                {
                    ans = Subtract(val1, val2);
                }
                else if (answer == "multiply")
                {
                    ans = Multiply(val1, val2);
                }
                else
                {
                    ans = Divide(val1, val2);
                }
                Console.WriteLine($"The answer is {ans}");
                Console.WriteLine($"What would you like to do? Type previous to run a new calculation using the answer of the previous calculation. Type new to run a new calculation with two new values. Type stop to stop the program.");
                result = Console.ReadLine().ToLower();

            } while (result != "stop");
            
            
            

            

        }

        /// <summary>
        /// Sums up two values
        /// </summary>
        /// <param name="val1">The left hand operand of the equation</param>
        /// <param name="val2">the right hand operand of the equation</param>
        /// <returns>the sum of the two numbers</returns>

        static double Add(double val1, double val2)
        {
            double number = val1 + val2;
            return number;
        }

        /// <summary>
        /// Subtracts two numbers
        /// </summary>
        /// <param name="val1">The left hand operand</param>
        /// <param name="val2">the right hand operand</param>
        /// <returns>The difference of the two numbers</returns>
       

        static double Subtract(double val1, double val2)
        {
            double number = val1 - val2;
            return number;
        }

        /// <summary>
        /// Multiplies two numbers together
        /// </summary>
        /// <param name="val1">the left hand operand</param>
        /// <param name="val2">the right hand operand</param>
        /// <returns>the product of the two values</returns>

        static double Multiply(double val1, double val2)
        {
            double number = val1 * val2;
            return number;
        }

        /// <summary>
        /// Divides two numbers together
        /// </summary>
        /// <param name="val1">the left hand operand</param>
        /// <param name="val2">the right hand operand</param>
        /// <returns>the quotient of the two numbers</returns>

        static double Divide(double val1, double val2)
        {
            double number = val1 / val2;
            return number;
        }

        /// <summary>
        /// Writes the developer info to the console
        /// </summary>
        /// <param name="devname">Name of developer</param>
        /// <param name="classname">class program was written for</param>
        /// <param name="date">date program was written</param>
        static void DeveloperInformation(string devname, string classname, string date)
        {
            Console.WriteLine($"{devname} wrote this program for {classname} on {date}.");
        }
    }
}
