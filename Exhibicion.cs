using System;

namespace examenM1
{
    class Exhibicion : Eventos
    {

       private string TipoVehiculo { get; set; }
       
        public void mostrarTipoVehiculo (string TV)
            { 
               TipoVehiculo = TV;
               Console.WriteLine($" El tipo de vehiculo es: {TV} ");                     
            }
        

        
    }
}
