using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal subtotal, IVA;
            decimal totalApagar, totalIva;
            decimal articulo1, articulo2, articulo3;


            Console.WriteLine("<< Cálculo de IVA >>");
          
            
            Console.WriteLine("Ingrese el precio del primer artículo: ");
            articulo1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del segundo artículo: ");
            articulo2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del tercer artículo: ");
            articulo3 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el % de IVA a agregarse: ");
            IVA = decimal.Parse(Console.ReadLine());


            subtotal = articulo1 + articulo2 + articulo3;
            IVA = (IVA / 100)+1;

            totalIva = (subtotal * IVA)- subtotal;
            totalApagar = subtotal * IVA;

            Console.WriteLine("Subtotal: ${0:N2}", subtotal);
            Console.WriteLine("Total IVA: ${0:N2}", totalIva);
            Console.WriteLine("Total a Pagar: ${0:N2}", totalApagar);
        }
    }
}
