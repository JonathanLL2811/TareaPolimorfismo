using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPolimorfismo
{
    class Motocicleta : Vehiculo
    {
        public override void Arrancar()
        {
            Console.WriteLine("La motocicleta está arrancando...");
        }

        public override void Detener()
        {
            Console.WriteLine("La motocicleta se está deteniendo...");
        }
    }

}
