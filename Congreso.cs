using System;

namespace examenM1
{
    class Congreso : Eventos
    {

       private string Conferencia { get; set; }

        
      public void mostrarConferencia (string CF)
            { 
               Conferencia = CF;
               Console.WriteLine($" la conferencia es: {CF} ");                     
            }
    }
}
