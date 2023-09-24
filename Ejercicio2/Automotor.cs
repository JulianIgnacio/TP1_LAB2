using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal abstract class Automotor
    {
        private string modelo { get; set; }

        private string patente { get; set; }
        public virtual void Acelerar() {
            Console.WriteLine("Se acelera");
        }

        public virtual void Frenar()
        {
            Console.WriteLine("Se frena");
        }
    }
}
