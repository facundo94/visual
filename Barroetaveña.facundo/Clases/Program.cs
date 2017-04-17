using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("El numero mas grande es: {0}",Math.Max(10,num));
            Console.ReadLine();
        }
    }
}
