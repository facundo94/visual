using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades3;

namespace PruebaTempera
{
    class Program
    {
        static void Main(string[] args)
         {
            Tempera tempera1 = new Tempera(ConsoleColor.Blue, "marca1", 1);
            Tempera tempera2 = new Tempera(ConsoleColor.Cyan, "marca2", 1);
            Tempera tempera3 = new Tempera(ConsoleColor.Blue, "marca1", 1);
            Tempera tempera4 = new Tempera(ConsoleColor.Red, "marca3", 1);

            Console.WriteLine(tempera1);
            
            Console.WriteLine();
            if (tempera1 != tempera2)
                Console.WriteLine("Son iguales");

            Console.WriteLine();
            if (tempera1 == tempera3)
                Console.WriteLine("No son iguales");

            Console.WriteLine();
            tempera1 = tempera1 + tempera3;
            Console.WriteLine(tempera1);

            Console.WriteLine();
            tempera2 = tempera2 + 5;
            Console.WriteLine(tempera2);

            Console.WriteLine();
            Console.WriteLine((string)tempera1);

            Console.WriteLine();
            Console.WriteLine(Tempera.Mostrar(tempera1));

            Paleta paleta = new Paleta(3);
            paleta.Agregar(tempera1, 0);
            paleta.Agregar(tempera4, 2);

            paleta = paleta + tempera2;

            Console.WriteLine();
            Console.WriteLine((string)paleta);

            Console.ReadLine();
        }
    }
}
