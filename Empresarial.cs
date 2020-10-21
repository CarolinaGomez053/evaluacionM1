using System;

namespace examenM1
{
    class Empresarial : Eventos
    {

       private string Sector { get; set; }
       
        public void mostrarSector(string ST)
            { 
              Sector  = ST;
               Console.WriteLine($" El sector es: {ST} ");                     
            }

        
    }
}
