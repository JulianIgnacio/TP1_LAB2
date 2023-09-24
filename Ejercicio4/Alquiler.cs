using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Alquiler
    {
        public int cantDias;

        public double precio;

        public double precioTotal;
        public double CalcularTotal(int cantDias,double precio)
        {
            precioTotal = precio * cantDias;

            return (precioTotal);
        }
    }
}
