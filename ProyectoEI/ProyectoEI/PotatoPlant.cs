using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEI
{
    public class PotatoPlant : Plant
    {
        public PotatoPlant()
        {
            Name = "Potato";
            LifeTime = 100;
            Yield = 10;
            SeedValue = 0.50M;
            ProductValue = 1.50M;
        }

        public override void Harvest()
        {
           Console.WriteLine($"YOU HAVE HARVESTED {Yield} POTATOS.");
        }
    }
}
