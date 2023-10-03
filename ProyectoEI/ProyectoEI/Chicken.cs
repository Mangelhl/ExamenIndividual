using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoEI
{
    public class Chicken : Animal
    {
        public Chicken() 
        {
            Name = "Hen";
            LifeTime = 1825; 
            Productivity = 150; 
            AnimalPrice = 20.0M;
            ProductPrice = 0.3M; 
        }

        public override void Produce()
        {
            Console.WriteLine($"THE HEN HAS PRODUCED {Productivity} EGGS.");
        }
    }
}
