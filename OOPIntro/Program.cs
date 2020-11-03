using OOPIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Program
    {
        SomeClass SomeClass;
        SomeClass SomeClass2;
        SomeClass SomeClass3;

        static void Main(string[] args)
        {
            //Car car = new Car();
            Engine engine = new Engine();
            Car car2 = new Car(engine); // engine

            House house = new House();
            //house.

            CountryHouse countryHouse = new CountryHouse();
            //countryHouse

            BuildingBlock bb = new BuildingBlock();
            //bb.
        }

        static void ExtraMethod(SomeClass SomeClass)
        {
            SomeClass.SomeMethod();
        }
    }
}
