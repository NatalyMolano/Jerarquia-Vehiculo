using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Manual : caja    
    {
        private bool transmisionManual;
        private bool Engranes;
        private bool palancavelocidades;
        private bool clutch;
        private bool flechaMando;

        public Manual()
        {
            transmisionManual = true;
            Engranes = true;
            palancavelocidades = true;
            clutch = true;
            flechaMando = true;
        }


        public void setManual(bool transmisionManual, bool Engranes, bool palancaVelocidades, bool clutch, bool flechaMando)
        {
            this.transmisionManual = transmisionManual;
            this.Engranes = Engranes;
            this.palancavelocidades = palancaVelocidades;
            this.clutch = clutch;
            this.flechaMando = flechaMando;
        }
        public string getManual()
        {
            return "La caja tiene la siguiente informacion: \n Si tiene transmision manual: \n"
            + transmisionManual + "Si tiene flecha de mandi: \n" + flechaMando +
            "Si  tiene palanca de velocidades: \n" + palancavelocidades + "Si tiene clutch: \n" + clutch + "Si tiene engranes: \n" + Engranes;
        }
        public bool AdministrarMotor()
        {
            Console.WriteLine("la caja manual administra la velocidad del motor");
            return true;
        }
    }
}
