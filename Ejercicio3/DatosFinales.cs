using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class DatosFinales
    {
        public double precioTotal { get;set;}

        public double CalcularPrecioTotal(double precioProducto,int cantidadProducto)
        {
            precioTotal = precioProducto * cantidadProducto;

            return precioTotal;
        }
    }
}
