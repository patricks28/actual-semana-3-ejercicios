using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_amortización_mensual_simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada: El usuario debe ingresar el monto del préstamo, la cantidad de meses y el interés mensual fijo
            Console.WriteLine("Ingrese el monto del préstamo: ");
            double mon = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el número de cuotas (meses): ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el interés mensual fijo: ");
            double inter = Convert.ToDouble(Console.ReadLine());

            //Proceso: Se calcula el monto mensual usando la fórmula mostrada en el código. (La fórmula del documento de clase está mal).
            double cuotamensual = Math.Round((mon + (1 + inter * mes)) / mes , 2); //Se redondea al número entero y solo 2 decimales
            
            //Salida
            Console.Write("La cuota mensual a pagar es de: S/." + cuotamensual);
            Console.ReadLine();
        }
    }
}
