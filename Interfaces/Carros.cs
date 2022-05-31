using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Carros : Transporte_de_personas
    {
        public Carros()
        {
            techo = true;
            puertas = 4;
            ventanas = 4;
            Capo = true;
        }

        private bool techo;
        private int puertas;
        private int ventanas;
        private bool Capo;

        public void setCarros(bool techo, int puertas, int ventanas, bool Capo)
        {
            this.techo = techo;
            this.puertas = puertas;
            this.ventanas = ventanas;
            this.Capo = Capo;
        }
        public string getCarros()
        {
            return "\n El vehiculo tiene la siguiente informacion: \n Si tiene techo: :"
                    + techo + "\n El numero de puertas: " + puertas +
                    "\n El numero de ventanas: " + ventanas + "\n Si tiene Capo: " + Capo;
        }
        public bool aireacondicionado()
        {
            Console.WriteLine("Si tiene aire acondicionado");
            return true;
        }
        public bool reproductoraudio()
        {
            Console.WriteLine("Si tiene radio");
            return true;
        }
        public bool LimpiaParabrisas()
        {
            Console.WriteLine("Si tiene limpiaparabrisas");
            return true;
        }
    }
}
