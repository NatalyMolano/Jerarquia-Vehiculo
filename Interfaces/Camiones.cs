using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    internal class Camiones : TransporteDeCarga
    {
        public Camiones()
        {
            techo = true;
            puertas = 3;
            ventanas = 2;
            parachoques = true;
            clindraje = 10;
            remolqueCarga = true;
            DepositoAceite = 1;
        }
        private bool techo;
        private int puertas;
        private int ventanas;
        private bool parachoques;
        private int clindraje;
        private bool remolqueCarga;
        private int DepositoAceite;

        public void setCamiiones(bool techo, int puertas, int ventanas, bool parachoques, int clindraje, bool remolqueCarga, int DepositoAceite)
        {
            this.techo = techo;
            this.puertas = puertas;
            this.ventanas = ventanas;
            this.parachoques = parachoques;
            this.clindraje = clindraje;
            this.remolqueCarga = remolqueCarga;
            this.DepositoAceite = DepositoAceite;
        }
        public string getCamiones()
        {
            return "El vehiculo tiene la siguiente informacion: \n Si tiene techo: "
              + techo + "\n El numero de puertas: " + puertas +
              "\n El numero de ventanas: " + ventanas + "\n Si tiene parachoques: " + parachoques + "\n El cilindraje: "
              + clindraje + "\n Si tiene remolque de carga: " + remolqueCarga + "\n El deposito de aceite: " + DepositoAceite;
           
        }

        public bool cargan()
        {
            Console.WriteLine("Los camiones cargan");
            return true;
        }
        public bool Enciendenmotor()
        {
            Console.WriteLine("El camion enciende el motor");
            return true;
        }
    }
}
