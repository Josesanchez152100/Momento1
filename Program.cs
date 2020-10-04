using System;

namespace Momento1
{
    class Program
    {
        static void Main(string[] args)
                {
                    Console.WriteLine("EVENTO");

                    Console.WriteLine("Fecha");
                    string fecha = Console.ReadLine();

                    Console.WriteLine("Lugar");
                    string lugar = Console.ReadLine();

                    Console.WriteLine("Hora");
                    string hora = Console.ReadLine();

                    Console.WriteLine("Precio");
                    int precio = int.Parse(Console.ReadLine());

                    Console.WriteLine("Capacidad");
                    int capacidad = int.Parse(Console.ReadLine());

                    Console.WriteLine("Duración");
                    string duracion = Console.ReadLine();

                var deportivoUno = new Deportivo()
                    {
                        Fecha = fecha,
                        Lugar = lugar,
                        Hora = hora,
                        Precio = precio,
                        Capacidad = capacidad,
                        Duracion = duracion
                    };
                
                deportivoUno.finTiempo();

                var empresarialUno = new Empresarial()
                    {
                        Fecha = fecha,
                        Lugar = lugar,
                        Hora = hora,
                        Precio = precio,
                        Capacidad = capacidad,
                        Duracion = duracion,
                    };
                
                empresarialUno.inspeccion();

                
            }             
                
    }        
}    