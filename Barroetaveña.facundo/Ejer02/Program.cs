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

            if (num <= 0)
            {
                Console.WriteLine("Error! Reingrese el numero!!!");
            }
            else
            {
                Console.Write("El numero {0}, su cuadrado es ",num);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}",Math.Pow(num,2));
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(", y su cubo ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("{0}",Math.Pow(num,3));
            }
            Console.ReadLine();
        }
    }
}
