using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Models
{
    class House : BuildingBlock
    {
        public string Address; // { get; set; }
        public House()
        {
            Console.WriteLine("This is the house");
        }
    }
}
