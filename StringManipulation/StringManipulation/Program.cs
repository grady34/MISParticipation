using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            string statement = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

            Console.WriteLine(statement);

            Console.WriteLine("Read the above statement and type in a word you want to look for in the above sentence. >>");
            string word = Console.ReadLine();
            Console.WriteLine("What word would you like to use as a replacement? >>");
            string newword = Console.ReadLine();

            bool contains = statement.Contains(word);

            if (contains)
            {
                Console.WriteLine(statement.Replace(word, newword));
            }
            else
            {
                Console.WriteLine("Sorry, I could not find your word " + word + ".");
            }
            for (int i = word.Length; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
