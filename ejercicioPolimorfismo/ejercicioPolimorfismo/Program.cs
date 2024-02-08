using ejercicioPolimorfismo;

internal class Program
{
    
        static void Main(string[] args)
        {
           
            Vehiculo vehiculo1 = new Automovil();
            Vehiculo vehiculo2 = new Motocicleta();
            Vehiculo vehiculo3 = new Bicicleta();

            
            vehiculo1.Arrancar();
            vehiculo1.Detener();

            vehiculo2.Arrancar();
            vehiculo2.Detener();

            vehiculo3.Arrancar();
            vehiculo3.Detener();
        }
    }
