using System;
using System.Collections.Generic;
using System.Text;
using Prb.Ee.Icecreams.Core.Entities;
using Prb.Ee.Icecreams.Core.Enums;

namespace Prb.Ee.Icecreams.Core.Services
{
   public class ShopService
    {

       public List<Flavour> Flavours { get; set; }
       //public List<Icecream> SoldIcecreams { get; set; }
        public int Revenue { get; set; }
        public ShopService()
        {
            //SoldIcecreams = new List<Icecream>();
            Flavours.Add(new Flavour(0.7M, "Chocolade"));
            Flavours.Add(new Flavour(0.8M, "Mokka"));
            Flavours.Add(new Flavour(1M, "Vanille"));
        }
        public void CreateSurpriseIcecream()
        {
             
        }
        public void SellIcecream()
        {
            
            if(Flavours.Count < 1)
            {
                throw new ArgumentException("U heeft geen bollen gekozen");
            }
        }


    }
}
