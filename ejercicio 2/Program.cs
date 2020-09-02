using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("La suma de los numeros es: ");
            int sum = n1 + n2;
            Console.WriteLine(sum);
            Console.Write("La resta de los numeros es: ");
            int rest = n1 - n2;
            Console.WriteLine(rest);
            Console.Write("La multiplicacion de los numeros es: ");
            int mult = n1 * n2;
            Console.WriteLine(mult);
            Console.Write("La division entre los numeros es: ");
            int div = n1 / n2;
            Console.WriteLine(div);

            Console.ReadKey();
        }
    }
}
