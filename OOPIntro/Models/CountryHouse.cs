using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Models
{
    class CountryHouse : BuildingBlock
    {
        public string CountryRoad;
        public CountryHouse()
        {
            Console.WriteLine("This is a country house!");
        }
    }
}
