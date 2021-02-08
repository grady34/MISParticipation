using System;

namespace Conditional_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick either heads or tails. >>");
            string answer = Console.ReadLine();
            
            if (answer == "heads")
            {

            }
            Random rand = new Random();
            int randomNbr = rand.Next(1, 3);
            Console.WriteLine($"{randomNbr}");
        }
    }
}
