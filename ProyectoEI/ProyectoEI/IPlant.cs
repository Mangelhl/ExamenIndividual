using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEI
{
    public interface IPlant
    {
        string Name { get; set; }
        int LifeTime { get; set; }
        int Yield { get; set; }
        decimal SeedValue { get; set; }
        decimal ProductValue { get; set; }

        void Harvest();
    }
}
