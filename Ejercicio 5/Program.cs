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
            Console.WriteLine("Introuzca la primera calificacion");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introuzca la segunda calificacion");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introuzca la tercera calificacion");
            int n3 = int.Parse(Console.ReadLine());

            int prom = (n1 + n2 + n3) / 3;
            Console.Write("La calificacion promedio es: " + prom);
            Console.ReadKey();
        }
    }
}
