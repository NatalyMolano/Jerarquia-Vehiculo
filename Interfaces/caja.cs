using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class caja : Carros
    {
        private bool piñones;
        private bool palanca;
        private bool Selectores;
        private bool Eje_intermedio;

        public caja()
        {
            piñones = true;
            palanca = true;
            Selectores = true;
            Eje_intermedio = true;
        }

        public void setInfoCaja(bool piñones, bool palanca, bool Selectores, bool Eje_intermedio)
        {
            this.piñones = piñones;
            this.palanca = palanca;
            this.Selectores = Selectores;   
            this.Eje_intermedio = Eje_intermedio;   
        }
        public string getInfoCaja()
        {
            return "\nLa caja del carro tiene la siguiente informacion " + "\n Existencia de piñones: " + piñones + "\n Existencia de palanca: " + palanca + "\n Existencia de Selectores: " + Selectores +
            "\n Existencia de Eje_intermedio: " + Eje_intermedio;
        }
        private bool AumentarMotor()
        {
            Console.WriteLine(" Sube la cantidad de revoluciones");
            return true;
        }
        private bool ReduceMotor()
        {
            Console.WriteLine(" Baja la cantidad de revoluciones");
            return true;
        }
        private bool InvertirMotor()
        {
            Console.WriteLine(" Inversion de sentido del giro del motor");
            return true;
        }


    }
}
