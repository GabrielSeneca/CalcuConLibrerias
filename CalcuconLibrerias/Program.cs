using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculos;

namespace CalcuconLibrerias
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("El resultado es: " + (CCalculos.Suma(10, 5)) + ", " + (CCalculos.Multi(10, 5)));

        }
        public static string Suma()
        {
            return "15";
        }

        public static string Multi()
        {
            return "50";
        }
    }
}
