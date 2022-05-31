using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Automaticos : caja
    {
        public Automaticos()
        {
            FlechaEntrada = true;
            BandaFreno = true;
            FlechaSalida = true;
            EngraneSolar = true;
            CuerpoValvulas = true;
            Modulador = true;
        }
        private bool FlechaEntrada;
        private bool BandaFreno;
        private bool FlechaSalida;
        private bool EngraneSolar;
        private bool CuerpoValvulas;
        private bool Modulador;


        public void setAutomaticos(bool FlechaEntrada, bool BandaFreno, bool FlechaSalida, bool EngraneSolar, bool CuerpoValvulas, bool Modulador)
        {
            this.FlechaEntrada = FlechaEntrada;
            this.FlechaSalida = FlechaSalida;
            this.BandaFreno = BandaFreno;
            this.EngraneSolar = EngraneSolar;
            this.CuerpoValvulas = CuerpoValvulas;
            this.Modulador = Modulador;
        }
        public string getAutomaticos()
        {
            return "La caja  tiene la siguiente informacion: \n Si tiene flecha entrada:"
            + FlechaEntrada + "\n Si tiene flecha de salida: " + FlechaSalida +
            "\n Si tiene banda de freno: " + BandaFreno + "\n Si tiene engrane solar: " + EngraneSolar + "\n Si tiene Valvulas de cuerpo: "
            + CuerpoValvulas + "\n Si tiene modulador: " + Modulador;
        }
        public bool RelacionCambioAutomatica()
        {
            Console.WriteLine("Si tiene cambios automaticos");
            return true;
        }
        public bool TransmisionAutomatica()
        {
            Console.WriteLine("Si tiene transmision automatica");
            return true;
        }
    }
}
