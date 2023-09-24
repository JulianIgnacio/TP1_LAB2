using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main()
        {
            string modeloAuto = "Mercedes";
            string patenteAuto = "AZT455";
            int caballosDeFuerza = 500;
            string modeloColectivo = "Mercedes";
            string patenteColectivo = "RTA699";
            int cantidadDeAsientos = 45;

            Automovil auto = new Automovil(modeloAuto,patenteAuto,caballosDeFuerza);

            Console.WriteLine("");

            auto.SacarFrenoMano();

            auto.Acelerar();

            Console.WriteLine("");

            ColectivoPasajero colectivo = new ColectivoPasajero(modeloColectivo,patenteColectivo,cantidadDeAsientos);

            Console.WriteLine("");

            colectivo.Frenar();

            colectivo.AbrirPuerta();


            Console.ReadKey();
        }
    }
}
