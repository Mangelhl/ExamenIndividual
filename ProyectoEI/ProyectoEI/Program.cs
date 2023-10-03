using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEI
{
    class Program
    {
        static void Main()
        {
            ProyectController proyectController = new ProyectController(1000.0M, 1);
            proyectController.StartProyect();
        }
    }
}
