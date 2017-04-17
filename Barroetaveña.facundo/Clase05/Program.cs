using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa cosa1 = new Cosa();
            Cosa cosa2 = new Cosa("Hola");
            Cosa cosa3 = new Cosa("Adios", DateTime.Today);
            Cosa cosa4 = new Cosa(25, "chau", DateTime.Today);          
           

            Console.WriteLine(cosa1.Mostrar());
            Console.WriteLine(cosa2.Mostrar());
            Console.WriteLine(cosa3.Mostrar());
            Console.WriteLine(cosa4.Mostrar());
            Console.ReadLine();
        }
    }
}
