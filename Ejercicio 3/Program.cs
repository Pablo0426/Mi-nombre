using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar = 58.29;
            Console.Write("Digite el monto en dolares: ");
            double pesos = double.Parse(Console.ReadLine());

            double result = dolar * pesos;
            Console.Write("Conversion a pesos dominicanos: ");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
