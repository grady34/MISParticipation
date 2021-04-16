using System;

namespace SimpleMethod_Speak
{
    class Program
    {
        public static string Speak(string animal)
        {
            string sound;

            if (animal == "dog")
            {
                sound = "ruff ruff";
            }
            else if (animal == "cat")
            {
                sound = "meowww";
            }
            else if (animal == "cow")
            {
                sound = "moooooooo";
            }
            else
            {
                sound = "eeeekkkk";
            }
            
            return sound;
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"Enter an animal. (dog, cat, or cow).");
            string answer = Console.ReadLine().ToLower();
            Console.WriteLine($"A {answer} makes the sound {Speak(answer)}!");
        }
    }
}
