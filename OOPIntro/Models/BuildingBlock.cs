using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Models
{
    class BuildingBlock
    {
        
        protected internal List<Door> Doors     = new List<Door>() 
                                    { new Door(), new Door() };
        internal List<Window> Windows = new List<Window>() 
                                    { new Window() };
        public List<Wall> Walls     = new List<Wall>() 
                                    { new Wall() };

        public BuildingBlock()
        {
            Console.WriteLine("This is a building block");
        }
    }
}
