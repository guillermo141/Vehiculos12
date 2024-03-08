using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    internal class MedioTransporte
    {
        protected string nombre {  get; set; }
        protected int capacidadpasajeros {  get; set; } 
        protected int cantidad {  get; set; }
         
        public  MedioTransporte(string nom, int cap, int cant ) 
        {
            this.nombre = nom;
            this.cantidad = cant;
            this.capacidadpasajeros = cap;
        }

        public int calcularPersonas()
        {
            return (capacidadpasajeros * cantidad);
        }

        public void mostrarmedioTransporte()
        {
            Console.WriteLine("Nombre: " + nombre);

            Console.WriteLine("Capacidad de pasajeros: " + capacidadpasajeros);

            Console.WriteLine("Cantidad que ingresan/dia: " + cantidad); 
        }

    }
}
