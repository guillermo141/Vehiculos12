using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    internal class Moto : MedioTransporte
    {
        private int cantCilindraje250 {  get; set; }

        public Moto(string nom, int cap, int cant, int cc250) : base(nom, cap, cant)
        {
            cantCilindraje250 = cc250;
        }
        public void mostrarMoto()
        {
            mostrarmedioTransporte();
                Console.WriteLine("cantidad de motos con cilindraje mayor a 250: " + cantCilindraje250);
                
        }
    }
}
