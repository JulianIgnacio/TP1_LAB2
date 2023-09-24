using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Automovil : Automotor
    {
        private int caballosDeFuerza { get; set; }

        public Automovil(string modelo, string patente,int caballosDeFuerza)
        {

            Console.WriteLine("El modelo de automovil es {0} su patente es {1} y sus caballos de fuerza {2}",modelo,patente,caballosDeFuerza);
        }
        public void SacarFrenoMano()
        {
            Console.WriteLine("Se saco el freno con exito");
        }
        public override void Acelerar()
        {
            Console.WriteLine("Una vez quitado el freno de mano se acelera con exito");
        }
    }
}
