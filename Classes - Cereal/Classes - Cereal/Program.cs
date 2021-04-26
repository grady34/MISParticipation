using System;
using System.Collections.Generic;
using System.IO;

namespace Classes___Cereal
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines("Cereal_Data.txt");

            List<Cereal> bowls = new List<Cereal>();

            for (int i = 1; i < lines.Length; i++)
            {

                string line = lines[i];

                string[] pieces = line.Split('|');

                string name = pieces[0];
                double calories = Convert.ToDouble(pieces[2]);
                double cups = Convert.ToDouble(pieces[3]);



                Cereal c = new Cereal();
                c.Name = name;
                c.Manufacturer = pieces[1];
                c.Calories = calories;
                c.Cups = cups;

                bowls.Add(c);

            }




        }
    }
}
