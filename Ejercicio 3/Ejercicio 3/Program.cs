using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma;
            int resta;
            int mult;
            decimal div;

            Console.WriteLine("Ingrese el primer número: ");
            short numero1 = short.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            short numero2 = short.Parse(Console.ReadLine());

            suma = numero1 + numero2;
            resta = numero1 - numero2;
            mult = numero1 * numero2;

            decimal d1 = Convert.ToDecimal(numero1);
            decimal d2 = Convert.ToDecimal(numero2);

            div = d1 / d2;

            Console.WriteLine("Calculando resultados...");

            Console.WriteLine("Resultado de la suma: {0}", suma);
            Console.WriteLine("Resultado de la resta: {0}", resta);
            Console.WriteLine("Resultado de la multiplicación: {0}", mult);
            Console.WriteLine("Resultado de la división: {0:N2}", div);
        }
    }
}
