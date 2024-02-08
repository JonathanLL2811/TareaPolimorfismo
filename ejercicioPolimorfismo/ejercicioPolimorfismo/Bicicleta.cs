using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPolimorfismo
{
    class Bicicleta : Vehiculo
    {
        public override void Arrancar()
        {
            Console.WriteLine("La bicicleta está arrancando...");
        }

        public override void Detener()
        {
            Console.WriteLine("La bicicleta se está deteniendo...");
        }
    }

}
