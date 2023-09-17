using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número base:");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número exponente:");
            int exp = int.Parse(Console.ReadLine());
            int potencia = 1;
            for (int i = 1; i <= exp; i++)
            {
                potencia = potencia * base1;
            }
            Console.WriteLine();
            Console.WriteLine("La potencia es: " + potencia);
            Console.ReadKey();
        }
    }
}
