using System;

namespace Mi_nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Como te llamas?");
            string nom = Console.ReadLine();
            Console.WriteLine("Hola mi nombre es " + nom);
            Console.ReadKey();
        }
    }
}
