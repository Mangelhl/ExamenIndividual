using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoEI
{
    public class Cow : Animal
    {
        public Cow() 
        {
            Name = "Cow";
            LifeTime = 3650;
            Productivity = 250;
            AnimalPrice = 500.0M;
            ProductPrice = 2.5M;
        }

        public override void Produce()
        {
            Console.WriteLine($"THE COW HAS PRODUCED {Productivity} LITERS OF MILK.");
        }
    }
}
