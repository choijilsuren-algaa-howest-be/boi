using System;
using System.Collections.Generic;
using System.Text;
using Prb.Ee.Icecreams.Core.Enums;

namespace Prb.Ee.Icecreams.Core.Entities
{
   public class Icecream
    {
        
        public List<Flavour> Scoops { get; private set; }
        public PackageType Package { get; set; }
        public Icecream(PackageType package)
        {
            Package = package;
            Scoops = new List<Flavour>();
            

        }

        public void AddScoop(Flavour scoops)
        {
            Scoops.Add(scoops);
        }
        public void DeleteScoop(Flavour scoops)
        {
            Scoops.Remove(scoops);
        }
        public bool HasScoops(Flavour scoops)
        {
       
            return true;
        }
        
        

        public override string ToString()
        {
            return $"{Package}         {Scoops} {Scoops} {Scoops}  Totaal: {Scoops.Count} ";
                                       
        }
    }
}
