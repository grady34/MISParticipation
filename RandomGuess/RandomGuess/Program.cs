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
            string guess;

            Console.WriteLine("What would you like the lower limit to be? >>");
            lowlimit = Console.ReadLine();
            int lowint = Convert.ToInt32(lowlimit);

            Console.WriteLine("What would you like the upper limit to be? >>");
            uplimit = Console.ReadLine();
            int upint = Convert.ToInt32(uplimit);

            Random rand = new Random();
            int randomNbr = rand.Next(lowint, upint + 1);

            int numguess;

            do
            {
                Console.WriteLine("Guess a number between your lower and upper limit. >>");
                guess = Console.ReadLine();
                while (int.TryParse(guess, out numguess) == false)
                {
                    Console.WriteLine("Incorrect value.  Your guess must be an integer >>");
                    guess = Console.ReadLine();
                }
                if (numguess == randomNbr)
                {
                    Console.WriteLine("You guessed correctly! Good Job!");
                }
                else
                {
                    Console.WriteLine("You guessed incorrectly try again.");
                }
            } while (numguess != randomNbr);


        }
    }
}
