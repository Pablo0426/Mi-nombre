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
            Console.Write("Digite la distancia en Millas: ");
            double milla = double.Parse(Console.ReadLine());

            double kilom = milla / 0.6213;
            Console.Write("El equibalente en Kilometros es: " + kilom);
            Console.ReadKey();
        }
    }
}
