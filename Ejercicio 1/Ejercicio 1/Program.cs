using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        decimal cantidad;
        decimal totalConversion;

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de millas marinas a convertir: ");
            decimal cantidad = decimal.Parse(Console.ReadLine());

            decimal totalConversion = cantidad * 1852;
            Console.WriteLine("Realizando conversión...");
            Console.WriteLine("{0} Millas Marinas equivalen a {1:N2} Metros", cantidad, totalConversion);

        }
    }
}
