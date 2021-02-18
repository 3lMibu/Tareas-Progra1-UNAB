using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;


            Console.WriteLine(" << CONVERTIDOR DE DIVISAS >> ");
            Console.WriteLine("1. Convertir Dolares a Colones.");
            Console.WriteLine("2. Convertir Colones a Dolares.");
            Console.WriteLine("3. Salir");
            Console.WriteLine(" << Seleccione una opción >> ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Digite la cantidad de Dolares a convertir: ");
                    short a = short.Parse(Console.ReadLine());
                    decimal Colones = a * 8.75M;
                    Console.WriteLine("${0} convertidos a colones son: {1} Colones.", a, Colones);
                    break;

                case 2:
                    Console.Write("Digite la cantidad de Colones a convertir: ");
                    short b = short.Parse(Console.ReadLine());
                    decimal Dolares = b * 0.11M;
                    Console.WriteLine("{0} Colones son: ${1} ", b, Dolares);
                    break;

                case 3:
                    Console.Write("Cerrando conversor de divisas");
                    break;
                default:
                    Console.WriteLine("Valor incorrecto");
                    break;
            }
            }
    }
}
