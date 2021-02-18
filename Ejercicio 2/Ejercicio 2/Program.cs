using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el capital aportado por el primer socio: ");
            decimal Capital1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el capital aportado por el segundo socio: ");
            decimal Capital2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el capital aportado por el tercer socio: ");
            decimal Capital3 = decimal.Parse(Console.ReadLine());

            decimal totalCapital = Capital1 + Capital2 + Capital3;

            decimal porcentajeCapt1 = (Capital1 * 100) / totalCapital;
            decimal porcentajeCapt2 = (Capital2 * 100) / totalCapital;
            decimal porcentajeCapt3 = (Capital3 * 100) / totalCapital;

            Console.WriteLine("El Total del capital formado es ${0:N2}", totalCapital);
            Console.WriteLine("Porcentaje aportado por cada socio es: ");
            Console.WriteLine("SOCIO 1 = {0:N2}%", porcentajeCapt1);
            Console.WriteLine("SOCIO 2 = {0:N2}%", porcentajeCapt2);
            Console.WriteLine("SOCIO 3 = {0:N2}%", porcentajeCapt3);

        }
    }
}