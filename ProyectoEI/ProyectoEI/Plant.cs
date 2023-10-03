using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEI
{
    public abstract class Plant : IPlant
    {
        public string Name { get; set; }
        public int LifeTime { get; set; }
        public int Yield { get; set; }
        public decimal SeedValue { get; set; }
        public decimal ProductValue { get; set; }

        public abstract void Harvest();
    }
}
