using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades3;

namespace TestNoNullTempera
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera t1 = new Tempera(ConsoleColor.Black,"asdasd",1);
            Tempera t2 = null;

            if (Tempera.NotNull(t2)&&(t2 == t1))
                Console.WriteLine("Son iguales!");
            else
                Console.WriteLine("No son iguales!");

            Console.ReadLine();

            //indexar 
        }
    }
}
