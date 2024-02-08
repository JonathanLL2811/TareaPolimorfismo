using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPolimorfismo
{
    class Automovil : Vehiculo
    {
        public override void Arrancar()
        {
            Console.WriteLine("El automóvil está arrancando...");
        }

        public override void Detener()
        {
            Console.WriteLine("El automóvil se está deteniendo...");
        }
    }
}
