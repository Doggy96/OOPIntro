using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Models
{
    class Car
    {
        //Engine e = new Engine();

        public Car()
        {
            Console.WriteLine("This is the Car!!!");
            //Engine e1 = new Engine();
            //Console.WriteLine($"e1: {e1}");
        }

        public Car(Engine engine)
        {
            Console.WriteLine(engine);
            Console.WriteLine("This is the Car");
            //Console.WriteLine(engine);
        }
    }
}
