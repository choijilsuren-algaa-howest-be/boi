using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Ee.Icecreams.Core.Entities
{
   public class Flavour
    {

        public decimal Price { get;private set; }
        public string Name { get; private set; }
        public Flavour( string name, decimal price)
        {
            Price = price;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}: € {Price}";
        }

    }
}
