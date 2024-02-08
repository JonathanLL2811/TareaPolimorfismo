using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPolimorfismo
{
    class Vehiculo
    {
        public virtual void Arrancar()
        {
            Console.WriteLine("El vehículo está arrancando...");
        }

        public virtual void Detener()
        {
            Console.WriteLine("El vehículo se está deteniendo...");
        }
    }

}
