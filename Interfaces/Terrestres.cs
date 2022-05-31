using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Terrestres : Vehiculos
    {
        private int ruedas;
        private bool manubrio;
        private string motor;
        private bool frenos;
        private int Luces;
        private bool Tubo_de_escape;
        private bool direccionales;
        private int Retrovisores;

        public Terrestres()
        {
            ruedas = 4;
            manubrio = true;
            motor = "gasolina";
            frenos = true;
            Luces = 7;
            Tubo_de_escape =true ;
            direccionales = true ;
            Retrovisores = 3;

        }
        public void setInfodeTerrestre(int ruedas,bool manubrio,string motor,bool frenos,int luces,bool Tubo_de_escape,bool direccionales,int Retrovisores)
        {
            this.ruedas = ruedas;
            this.manubrio = manubrio;
            this.motor = motor;
            this.frenos = frenos;
            this.Luces = luces; 
            this.Tubo_de_escape = Tubo_de_escape;   
            this.direccionales = direccionales;
            this.Retrovisores=Retrovisores;

        }
        public string getInfodeTerrestre()
        {
            return "El vehiculo terrestre tiene la siguiente informacion: \n numero de ruedas:" + ruedas +
                "\n Manubrio " + manubrio + "\n Tipo de motor " + motor + "\n Frenos " + frenos + "\n Luces " + Luces +
                "\n Tubo de escape: " + Tubo_de_escape + "\n Direccionales " + direccionales + " Cantidad de retrovisores" +
                Retrovisores;
        }

        private bool Frenar ()
        {
            Console.WriteLine("El vehiculo puede frenar");
            return true;
        }
        private bool acelerar()
        {
            Console.WriteLine("Se puede acelerar la velocidad del vehiculo");
            return true;
        }
        private bool desacelerar()
        {
            Console.WriteLine("Se puede desacelerar la velocidad del vehiculo");
            return true;
        }

    }
}
