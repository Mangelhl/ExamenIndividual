using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEI
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int LifeTime { get; set; }
        public int Productivity { get; set; }
        public decimal AnimalPrice { get; set; }
        public decimal ProductPrice { get; set; }

        public abstract void Produce();
    }
}
