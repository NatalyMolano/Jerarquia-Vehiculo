using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Transporte_de_personas:Terrestres
    {
        public Transporte_de_personas()
        {
            CantidadDePersonas = 5;
            Conductores = "Carlos Rodriguez";
            pasajeros = 4;
        }
        private int CantidadDePersonas;
        private string Conductores;
        private int pasajeros;

        public void SetInfoTransportePersonas(int CantidadDePersonas, string Conductores, int pasajeros)
        {
            this.CantidadDePersonas = CantidadDePersonas;
            this.Conductores = Conductores;
            this.pasajeros = pasajeros;
        }
        public string getInfoTRansportePersonas()
        {
            return "El vehiculo tiene la siguiente informacion: \n La cantidad de personas: "
            + CantidadDePersonas + "\n El nombre del conductor: " + Conductores +
            "\n El numero de pasajeros: " + pasajeros;
        }
        public bool SubirPersonas()
        {
            Console.WriteLine("Tiene la funcion de subir personas");
            return true;
        }
        public bool BajarPersonas()
        {
            Console.WriteLine("Tiene la funcion de bajar personas");
            return true;
        }
    }
}
