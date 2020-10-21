using System;

namespace examenM1
{
    class Cultural : Eventos
    {

       private string Pais { get; set; }
     
      public void mostrarPais (string PS)
            { 
               Pais = PS;
               Console.WriteLine($" El pais: {PS} ");                     
            }
        
    }
}
