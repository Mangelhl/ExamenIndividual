using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEI
{
    public class ApplePlant : Plant
    {
        public ApplePlant()
        {
            Name = "Apple";
            LifeTime = 80;
            Yield = 8;
            SeedValue = 0.30M;
            ProductValue = 1.0M;
        }

        public override void Harvest()
        {
            Console.WriteLine($"YOU HAVE HARVESTED {Yield} APPLES.");
        }
    }
}
