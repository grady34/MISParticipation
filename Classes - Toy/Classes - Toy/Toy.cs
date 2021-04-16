using System;
using System.Collections.Generic;
using System.Text;

namespace Classes___Toy
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        
        public string Name { get; set; }
        

        public double Price { get; set; }


        private string Notes; 
            public string GetNotes()
            {
                return Notes;
            }

            public void SetNotes(string note)
            {
                Notes = note;
            }


        public Toy()
        {
            Manufacturer = "N/A";
            Name = "N/A";
            Price = 0.00;
            Notes = "N/A";
        }

        public Toy(string manufacturer, string name, double price, string notes)
        {
            this.Manufacturer = manufacturer;
            this.Name = name;
            this.Price = price;
            this.Notes = notes;
        }

        public string GetAisle()
        {
            string letter = Manufacturer.Substring(startIndex: 0, 1);
            Random rand = new Random();
            int aislenum = rand.Next(1, 25);
            string aisle = letter.ToUpper() + Convert.ToString(aislenum);

            return aisle;
        }

    }
}
