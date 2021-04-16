using System;

namespace Classes___Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toy1 = new Toy();
            toy1.Manufacturer = "Hasbro";
            toy1.Name = "Action Figure";
            toy1.Price = 10.21;
            toy1.SetNotes("This is an action figure");
            string toy1notes = toy1.GetNotes();
            string toy1aisle = toy1.GetAisle();

            Console.WriteLine($"Toy Manufacturer: {toy1.Manufacturer}, Toy Name: {toy1.Name}, Toy Price: ${toy1.Price}, Toy Notes: {toy1notes}. The toy is on aisle {toy1aisle}.");

            Toy toy2 = new Toy();
            toy2.Manufacturer = "Lego";
            toy2.Name = "Harry Potter Legos";
            toy2.Price = 75.33;
            toy2.SetNotes("This is a Harry Potter lego set with 1000 pieces");
            string toy2notes = toy2.GetNotes();
            string toy2aisle = toy2.GetAisle();

            Console.WriteLine($"Toy Manufacturer: {toy2.Manufacturer}, Toy Name: {toy2.Name}, Toy Price: ${toy2.Price}, Toy Notes: {toy2notes}. The toy is on aisle {toy2aisle}.");
        }
    }
}
