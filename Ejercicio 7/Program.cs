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
            Console.Write("Digite el valor de la base del trinangulo: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Digite el valor de la altura del trinangulo: ");
            double Al = double.Parse(Console.ReadLine());

            double Area = (B * Al) / 2;
            Console.WriteLine("El area del trinangulo es " + Area);
            Console.ReadKey();
        }
    }
}
