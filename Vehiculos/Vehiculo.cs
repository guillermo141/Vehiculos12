using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    internal class Vehiculo : MedioTransporte
    {
        private int cantidadgas {  get; set; }
        private int cantidadGasolina { get; set; }

        public Vehiculo(string nom, int cap, int cant, int cgas, int cgaso) : base (nom, cap, cant) 
        {
                
                this.cantidadgas = cgas;
                this.cantidadGasolina = cgaso;
        }
        public void mostrarVehiculo()
        {
            mostrarmedioTransporte();
                {
                Console.WriteLine("Cantidad de vehiculos a gas: " + cantidadgas);
                Console.WriteLine("Cantidad de vehiculos a gasolina: " + cantidadGasolina);
                }

        }
    }
}
