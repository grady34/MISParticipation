using System;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Random Number Guessing Game!!");

            string lowlimit;
            string uplimit;

            Console.WriteLine("What would you like the lower limit to be? >>");
            lowlimit = Console.ReadLine();
            int lowint = Convert.ToInt32(lowlimit);

            Console.WriteLine("What would you like the upper limit to be? >>");
            uplimit = Console.ReadLine();
            int upint = Convert.ToInt32(uplimit);

            Random rand = new Random();
            int randomNbr = rand.Next(lowint, upint + 1);

            Console.WriteLine("Guess a number between your lower and upper limit. >>");
            // need to make sure they only enter a number tryparse
            // need to make a do while loop so if they guess wrong they can try again and again until they guess correct
           


        }
    }
}
