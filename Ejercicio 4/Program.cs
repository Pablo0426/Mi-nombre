using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la temperatura en °F:");
            double fahren = double.Parse(Console.ReadLine());

            double celsius = (fahren - 32) * 5 / 9;
            Console.WriteLine("La coversion de °F a °C es: " + celsius);
            Console.ReadKey();
        }
    }
}
