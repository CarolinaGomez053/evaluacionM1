using System;

namespace examenM1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eventualit");

            Console.WriteLine("Tipo de evento");
            string tipo = Console.ReadLine();

        

             Console.WriteLine("Organizador");
            string organizador = Console.ReadLine();


            //deportivos
             Console.WriteLine("Equipo");
            string equipo = Console.ReadLine();

             Console.WriteLine("Deporte");
            string deporte = Console.ReadLine();

            //cultural
             Console.WriteLine("País");
            string pais = Console.ReadLine();

            //empresarial
             Console.WriteLine("Sector");
            string sector = Console.ReadLine();

            //feria
             Console.WriteLine("Talento");
            string talento = Console.ReadLine();


            //exhibisión
           Console.WriteLine("Tipo de Vehiculo");
            string tipovehiculo = Console.ReadLine();


            //congreso
             Console.WriteLine("Conferencia");
            string conferencia = Console.ReadLine();

        


            Deportivos eDeportivos = new Deportivos()
            {
                   Tipo = tipo,
                   Organizador = organizador
                               
            };
            



               Cultural eCultural = new Cultural ()
            {
                   Tipo = tipo,
                  
                   Organizador = organizador,
                   

            };

                Empresarial eEmpresarial = new Empresarial ()
            {
                   Tipo = tipo,
                   
                   Organizador = organizador

            };

                Feria eFeria = new Feria ()
            {
                   Tipo = tipo,
                   
                   Organizador = organizador

            };

                Exhibicion eExhibicion = new Exhibicion()
            {
                   Tipo = tipo,
                   
                   Organizador = organizador

            };

               Congreso eCongreso = new Congreso()
            {
                   Tipo = tipo,
                  
                   Organizador = organizador

            };

            

            Console.WriteLine($"{eDeportivos.Tipo} {eDeportivos.Organizador}");
            eDeportivos.mostrarEquipo(equipo);
            eDeportivos.mostrarDeporte(deporte);
            
            Console.WriteLine($"{eCultural.Tipo} {eCultural.Organizador}");
            eCultural.mostrarPais(pais);

            Console.WriteLine($"{eEmpresarial.Tipo} {eEmpresarial.Organizador}");
            eEmpresarial.mostrarSector(sector);

            Console.WriteLine($"{eFeria.Tipo} {eFeria.Organizador}");
            eFeria.mostrarTalento(talento);

            Console.WriteLine($"{eExhibicion.Tipo} {eExhibicion.Organizador}");
            eExhibicion.mostrarTipoVehiculo(tipovehiculo);

            Console.WriteLine($"{eCongreso.Tipo} {eCongreso.Organizador}");
            eCongreso.mostrarConferencia(conferencia);
            
                




        }
    }
}
