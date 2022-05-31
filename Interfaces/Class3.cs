using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al menu");
            Console.WriteLine("Elija 1 si desea ver la clase de Vehiculos");
            Console.WriteLine("Elija 2 si desea ver la clase de Terrestres");
            Console.WriteLine("Elija 3 si desea ver la clase de Transporte de personas");
            Console.WriteLine("Elija 4 si desea ver la clase de Transporte de carga");
            Console.WriteLine("Elija 5 si desea ver la clase de Camiones");
            Console.WriteLine("Elija 6 si desea ver la clase de Carros");
            Console.WriteLine("Elija 7 si desea ver la clase de Caja");
            Console.WriteLine("Elija 8 si desea ver la clase de Manual");
            Console.WriteLine("Elija 9 si desea ver la clase de automatico");

            int eleccion;
            eleccion = char.Parse(Console.ReadLine());
            switch (eleccion)
            {
                case '1':
                    Vehiculos carro1 = new Vehiculos();
                    Console.WriteLine(carro1.getInfoVehiculo()); break;

                case '2':
                    Terrestres terrestres = new Terrestres();
                    Console.WriteLine(terrestres.getInfodeTerrestre()); break;

                case '3':
                    Transporte_de_personas persona = new Transporte_de_personas();
                    Console.WriteLine(persona.getInfoTRansportePersonas()); break;

                case '4':
                    TransporteDeCarga carga = new TransporteDeCarga();
                    Console.WriteLine(carga.getInfoTRansporteCarga()); break;
                case '5':
                    Carros carro = new Carros();
                    Console.WriteLine(carro.getCarros()); break;
                case '6':
                    Camiones camion = new Camiones();
                    Console.WriteLine(camion.getCamiones());  break;
                case '7':
                    caja Caja = new caja();
                    Console.WriteLine(Caja.getInfoCaja()); break;

                case '8':
                    Manual manual = new Manual();
                    Console.WriteLine(manual.getManual()); break;
                case '9':
                    Automaticos automatico = new Automaticos();
                    Console.WriteLine(automatico.getAutomaticos()); break;
                default: Console.WriteLine("No especifico ninguna opcion valida "); break;


            }





            

            
            
            
            

            
          


        }
    }
}
