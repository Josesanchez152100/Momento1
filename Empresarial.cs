using System;

namespace Momento1
{
    class Empresarial : Evento
    {
        
        //public string Vestuario { get; set;}           
            
        public void inspeccion(){

                Console.WriteLine("¿El vestuario del invitado es formal?");
                string vestuario = Console.ReadLine();

                if(vestuario == "si")
                {
                    Console.WriteLine("Bienvenido al evento");
                }
                else
                {
                    Console.WriteLine("Porfavor cambie su vestuario para poder ingresar al evento");
                }

        }           
    }
    
}