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

            Console.WriteLine("El resultado es: " + (CCalculos.Suma(10, 5)));

        }
        public static string Suma()
        {
            return "15";
        }

        public static double Multi()
        {
            double result = 5*10;
            return result;
        }

        public static double Div()
        {
            double result = 50 / 10;
            return result;
        }


    }
}
