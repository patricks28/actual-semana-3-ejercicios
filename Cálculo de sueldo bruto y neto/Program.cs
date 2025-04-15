using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_sueldo_bruto_y_neto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada: nombre, horas trabajadas, pago por hora, descuento.
            Console.WriteLine("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese las horas trabajadas: ");
            double horas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el pago por hora: ");
            double pago = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingres el porcentaje de descuento por retenciones: ");
            double retencion = Convert.ToDouble(Console.ReadLine());

            //Proceso: 
            double sueldob = horas * pago; //Calculo de sueldo bruto
            double desc = sueldob * (retencion/100); //Calculo de descuento por retención
            double sueldon = sueldob - desc; // Calculo del sueldo neto

            //Salida
            Console.WriteLine("Sueldo bruto: S/."+ sueldob);
            Console.WriteLine("Descuento por retención: S/." + desc);
            Console.WriteLine("Sueldo neto a recibir: S/."+ sueldon);
            Console.ReadLine();
        }
    }
}
