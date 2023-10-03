using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEI
{
    public interface IAnimal
    {
        string Name { get; set; }
        int LifeTime { get; set; }
        int Productivity { get; set; }
        decimal AnimalPrice { get; set; }
        decimal ProductPrice { get; set; }

        void Produce();
    }
}
