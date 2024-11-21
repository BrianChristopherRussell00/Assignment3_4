using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_4WINFORMS
{
    public class Coffee : Beverage
    {
        public enum Roast
        {
            Light,
            Medium,
            Dark

        }
        public enum Temperature {Hot,Iced }
        public string BrewStrength { get; set; }
        public Roast RoastType { get; set; }
        public Temperature CoffeeTemperature { get; set; }


    }
}
