using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class TransporteDeCarga : Terrestres
    {
        public TransporteDeCarga()
        {
            TipoCarga = "Animales";
            CantidadCarga = 6;
            PesoCarga = 75;
        }
        private string TipoCarga;
        private int CantidadCarga;
        private float PesoCarga;

        public void SetInfoTransporteCarga(string TipoCarga, int CantidadCarga, float PesoCarga)
        {
            this.TipoCarga = TipoCarga;
            this.CantidadCarga = CantidadCarga;
            this.PesoCarga = PesoCarga;
        }
        public string getInfoTRansporteCarga()
        {
            return "El vehiculo tiene la siguiente informacion: \n El tipo de la carga:"
            + TipoCarga + "\n La cantidad de la carga es: " + CantidadCarga +
            "\n El peso de la carga: " + PesoCarga;
        }
        public bool SubirCarga()
        {
            Console.WriteLine("Sube la carga al vehiculo");
            return true;
        }
        public bool BajarrCaga()
        {
            Console.WriteLine("Baja la carga del vehiculo");
            return true;
        }
    }
}
