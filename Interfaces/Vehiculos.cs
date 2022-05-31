using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Vehiculos
    {


        public Vehiculos()
        {
            NombreVehiculo = "Carro";
            ColorVehiculo = "Rojo";
            AltoVehiculo = 1.517;
            AnchoVehiculo = 1.735;
            LargoVehiculo = 4.399;
            ModeloVehiculo = "SUV";
            CapacidadVehiculo = 5;
            UsoVehiculo = '0';
            VelocidadVehiculo = 0;
            AsientosVehiculos = 5;
            //10
        }
        private string NombreVehiculo;
        private string ColorVehiculo;
        private double AltoVehiculo;
        private double LargoVehiculo;
        private double AnchoVehiculo;
        private string ModeloVehiculo;
        private int CapacidadVehiculo;
        private char UsoVehiculo;
        private double VelocidadVehiculo;
        private int AsientosVehiculos;

        public void setInfoVehiculo(double AltoVehiculo, double LargoVehiculo, double AnchoVehiculo, double VelocidadVehiculo, string NombreVehiculo, string ColorVehiculo, string ModeloVehiculo, int CapacidadVehiculo, int AsientosVehiculo, char UsoVehiculo)
        {   this. AltoVehiculo = AltoVehiculo;
            this. LargoVehiculo = LargoVehiculo;
            this. AnchoVehiculo = AnchoVehiculo;
            this. VelocidadVehiculo = VelocidadVehiculo;
            this. NombreVehiculo = NombreVehiculo;
            this. CapacidadVehiculo = CapacidadVehiculo;
            this. ModeloVehiculo = ModeloVehiculo;
            this. AsientosVehiculos = AsientosVehiculo;
            this. UsoVehiculo = UsoVehiculo;
            this. ColorVehiculo = ColorVehiculo;
        }
        public string getInfoVehiculo()
        {
            return "El vehiculo tiene la siguiente informacion: \n El alto del vehiculo: " + AltoVehiculo + " \n El largo del vehiculo: " + LargoVehiculo +
                  " \n El ancho del vehiculo: " + AnchoVehiculo + " \n La velocidad del velocidad: " + VelocidadVehiculo + "\n El nombre del vehiculo: " + NombreVehiculo +
                  "\n El color del vehiculo es: " + ColorVehiculo + "\n El modelo del vehiculo: " + ModeloVehiculo + "\n La capacidad del vehiculo es: " + CapacidadVehiculo +
                  "\n El uso del vehiculo es: " + UsoVehiculo + "\n Los asientos del vehiculo: " + AsientosVehiculos; 
        }
        
        
        public bool Transportar ()
        {
            return true; 
        }
        public bool Avanzar()
        {
            return true; 
        }
        public bool Retroceder()
        { return true; }
        public bool Girar()
        { return true; }
    }
    
}



