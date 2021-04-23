using System;
using System.Collections.Generic;
using System.Text;

namespace ToyBox
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public string Owner { get; set; }

        public string Location { get; set; }

        public ToyBox()
        {

        }

        public Toy GetRandomToy()
        {
            int number = Toys.Count;
            Random rand = new Random();
            int randnumber = rand.Next(0, number);
            Toy randtoy = Toys[randnumber];
            return randtoy;
        }
    }
}
