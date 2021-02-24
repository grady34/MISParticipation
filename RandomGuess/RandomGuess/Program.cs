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
            int lowint;
            int upint;

            Console.WriteLine("What would you like the lower limit to be? >>");
            lowlimit = Console.ReadLine();
            
            //Check if the input in an integer

            while (int.TryParse(lowlimit, out lowint) == false)
            {
                Console.WriteLine("Incorrect value.  Your lower limit must be an integer >>");
                lowlimit = Console.ReadLine();
            }

            Console.WriteLine("What would you like the upper limit to be? >>");
            uplimit = Console.ReadLine();
            
            //check if the input is an integer

            while (int.TryParse(uplimit, out upint) == false)
            {
                Console.WriteLine("Incorrect value.  Your upper limit must be an integer >>");
                uplimit = Console.ReadLine();
            }

            Random rand = new Random();
            int randomNbr = rand.Next(lowint, upint + 1);

            int numguess;

            do
            {
                Console.WriteLine("Guess a number between your lower and upper limit. >>");
                guess = Console.ReadLine();
                //check if the input is an integer
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
