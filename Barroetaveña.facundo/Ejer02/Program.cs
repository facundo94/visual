using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (num <= 0)
            {
                Console.WriteLine("ERROR. Reingresar número!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El numero es {0}, su cuadrado es {1} y su cubo {2}", num, Math.Pow(num, 2), Math.Pow(num, 3));
            }

            Console.ReadLine();
        }
    }
}
