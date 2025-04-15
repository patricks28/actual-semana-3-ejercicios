using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversión_de_moneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de dinero en dólares: ");
            double usd = double.Parse(Console.ReadLine());

            double eur = Math.Round((usd * 0.93) , 2);
            double mxn = Math.Round((usd * 17.5), 2);
            double pen = Math.Round((usd * 3.8) , 2);

            Console.WriteLine("Cantidad convertida en Euros: " + eur);
            Console.WriteLine("Cantidad convertida en Pesos Mexicanos: " + mxn);
            Console.WriteLine("Cantidad convertida a Soles: " + pen);
            Console.ReadLine();
        }
    }
}
