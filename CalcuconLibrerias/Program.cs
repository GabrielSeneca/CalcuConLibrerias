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
            Console.WriteLine("El resultado es:");
            Console.WriteLine(CCalculos.Suma(10, 5));
            //double r = 0;

            //r = CCalculos.Suma(2, 2);
            //Console.WriteLine(r);
        }

        public static string Test()
        {
            return "prueba test";
        }
    }
}
