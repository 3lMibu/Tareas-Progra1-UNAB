using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            
            
            Console.WriteLine(">> Ingrese el numero A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(">> Ingrese el numero B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(">> Ingrese el numero C: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a>c)
            {
                Console.WriteLine("El numero mayor es A: {0}", a);
                
                if (b>c)
                {
                    Console.WriteLine("El numero medio es B: {0}", b);
                    Console.WriteLine("El numero menor es C: {0}", c);
                }
                else
                {
                    Console.WriteLine("El numero medio es C: {0}", c);
                    Console.WriteLine("El numero menor es B: {0}", b);
                }
            }
            else
            {
                if (b > a && b > c)
                {
                    Console.WriteLine("El numero mayor es B: {0}", b);

                    if(a>c)
                    {
                        Console.WriteLine("El numero medio es A: {0}", a);
                        Console.WriteLine("El numero menor es C: {0}", c);
                    }
                    else
                    {
                        Console.WriteLine("El numero medio es C: {0}", c);
                        Console.WriteLine("El numero menor es A: {0}", a);
                    }
                }
                else
                {
                    Console.WriteLine("El numero mayor es C: {0}", c);
                    if (a>b)
                    {
                        Console.WriteLine("El numero medio es A: {0}", a);
                        Console.WriteLine("El numero menor es B: {0}", b);
                    }
                    else
                    {
                        Console.WriteLine("El numero medio es B: {0}", b);
                        Console.WriteLine("El numero menor es A: {0}", a);
                    }
                }
            }

        }
    }
}
