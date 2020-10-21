using System;

namespace examenM1
{
    class Deportivos : Eventos
    {

       private string Equipo { get; set; }
       private string Deporte { get; set; }

       public void mostrarEquipo(string EQ)
            { 
               Equipo = EQ;
               Console.WriteLine($" El equipo es: {EQ} ");                     
            }

      public void mostrarDeporte (string DP)
            { 
               Deporte = DP;
               Console.WriteLine($" El deporte es: {DP} ");                     
            }
    }
}
