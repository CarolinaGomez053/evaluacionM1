using System;

namespace examenM1
{
    class Feria : Eventos
    {

       private string Talento { get; set; }

         public void mostrarTalento (string TL)
            { 
               Talento = TL;
               Console.WriteLine($" El talento es: {TL} ");                     
            }
        

        
    }
}
