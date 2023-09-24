using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class ColectivoPasajero : Automotor
    {
        private int cantidadDeAsientos {  get; set; }

        public ColectivoPasajero(string modelo,string patente,int cantidadDeAsientos)
        {
            Console.WriteLine("El colectivo posee {0} asientos , su modelo es {1} y tiene de patente {2}",cantidadDeAsientos,modelo,patente);
        }
        public override void Frenar()
        {
            Console.WriteLine("Se frena con el freno de aire");
        }
        public void AbrirPuerta()
        {
            Console.WriteLine("Se abrio la puerta con exito");
        }
    }
}
