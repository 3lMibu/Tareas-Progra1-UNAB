using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sueldoBase, sueldoNeto, renta, isss, afp, descuentoTotal;
            decimal valorHoraExtra, sueldoConHorasExtras, horasExtra, sumaHorasExtras;
            decimal dscRenta, dscISSS, dscAFP, valorHora, horasTrabajadas, totalHorasExtra;
            string empleado;

            Console.WriteLine("Ingrese el nombre del empleado: ");
            empleado = Console.ReadLine();
            Console.WriteLine("Ingrese el número de horas trabajadas por {0}", empleado);
            horasTrabajadas = short.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor de hora trabajada: ");
            valorHora = decimal.Parse(Console.ReadLine());


            if (horasTrabajadas > 44)
            {
                totalHorasExtra = horasTrabajadas - 44; //total de horas trabajadas menos 44 = horas extras
                valorHoraExtra = valorHora * 1.5M; // valor de hora extra con el aumento del 150%
                sumaHorasExtras = totalHorasExtra * valorHoraExtra; //total de horas extras por la hora extra con el 150%
                sueldoBase = 44 * valorHora; // sueldo base siempre sera de 44 se le suma las horas extras
                sueldoConHorasExtras = sueldoBase + sumaHorasExtras; //total del sueldo base con las horas extras agregadas al 150%

                dscRenta = ((sueldoConHorasExtras * 9M) / 100);
                dscISSS = ((sueldoConHorasExtras * 3M) / 100);
                dscAFP = ((sueldoConHorasExtras * 6.25M) / 100);
                descuentoTotal = dscRenta + dscISSS + dscAFP;
                sueldoNeto = sueldoConHorasExtras - descuentoTotal;

                Console.WriteLine("<< Detalle de Salario con Horas Extras >>");
                Console.WriteLine("Empleado : {0}", empleado);
                Console.WriteLine("Salario Nominal : ${0:N2}", sueldoConHorasExtras);
                Console.WriteLine("Total Descuento Renta : ${0:N2}", dscRenta);
                Console.WriteLine("Total Descuento ISSS : ${0:N2}", dscISSS);
                Console.WriteLine("Total Descuento AFP : ${0:N2}", dscAFP);
                Console.WriteLine("Descuento Total Aplicado : ${0:N2}", descuentoTotal);
                Console.WriteLine("Sueldo Neto : ${0:N2}", sueldoNeto);

            }

            else
            {

                sueldoBase = horasTrabajadas * valorHora;
                dscRenta = ((sueldoBase * 9M) / 100);
                dscISSS = ((sueldoBase * 3M) / 100);
                dscAFP = ((sueldoBase * 6.25M) / 100);
                descuentoTotal = dscRenta + dscISSS + dscAFP;
                sueldoNeto = sueldoBase - descuentoTotal;

                Console.WriteLine("<< Detalle de Salario >>");
                Console.WriteLine("Empleado : {0}", empleado);
                Console.WriteLine("Salario Nominal : ${0:N2}", sueldoBase);
                Console.WriteLine("Total Descuento Renta : ${0:N2}", dscRenta);
                Console.WriteLine("Total Descuento ISSS : ${0:N2}", dscISSS);
                Console.WriteLine("Total Descuento AFP : ${0:N2}", dscAFP);
                Console.WriteLine("Descuento Total Aplicado : ${0:N2}", descuentoTotal);
                Console.WriteLine("Sueldo Neto : ${0:N2}", sueldoNeto);


            }







        }
    }
}