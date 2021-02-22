using System;

namespace Conditional_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            const string devname = "Grady Allen";

            Console.WriteLine("Please pick either heads or tails. >>");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "heads")
            {
              
            }
            else if (answer.ToLower() == "tails")
            {
               
            }
            else
            {
                Console.WriteLine($"ERROR. {answer} is not heads or tails.");
                Console.WriteLine($"This aplication was created by {devname}.");
                return;
            }

            Random rand = new Random();
            int randomNbr = rand.Next(1, 3);

            if (randomNbr == 1)
            {
                if (answer.ToLower() == "heads")
                {
                    Console.WriteLine("You were CORRECT the coin landed on HEADS");
                }
                else if (answer.ToLower() == "tails")
                {
                    Console.WriteLine("You were INCORRECT the coin landed on HEADS");
                }
            }
            else if (randomNbr == 2)
            {
                if (answer.ToLower() == "tails")
                {
                    Console.WriteLine("You were CORRECT the coin landed on TAILS");
                }
                else if (answer.ToLower() == "heads")
                {
                    Console.WriteLine("You were INCORRECT the coin landed on TAILS");
                }
            }

            Console.WriteLine($"This aplication was created by {devname}.");
            return;
        }
    }
}
