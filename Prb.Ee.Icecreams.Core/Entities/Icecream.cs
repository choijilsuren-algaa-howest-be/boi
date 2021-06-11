using System;
using System.Collections.Generic;
using System.Text;
using Prb.Ee.Icecreams.Core.Enums;

namespace Prb.Ee.Icecreams.Core.Entities
{
    class Icecream
    {
        
        public List<Flavour> Scoops { get; set; }
        public PackageType Package { get; set; }
        public Icecream(PackageType package)
        {
            Package = package;
            Scoops = new List<Flavour>();
            

        }

        public void AddScoop(List<Flavour> scoops)
        {
            
        }
        public string DeleteScoop()
        {
            if(Scoops !=null)
            {
                
            }
            return $"";
        }
        public string HasScoops()
        {
            return $"";
        }
        

        public override string ToString()
        {
            return $"{Package}         ";
        }
    }
}
