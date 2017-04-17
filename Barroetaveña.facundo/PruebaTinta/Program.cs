using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades2;

namespace PruebaTinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta1 = new Tinta();
            Tinta tinta2 = new Tinta(ConsoleColor.White);
            Tinta tinta3 = new Tinta(ConsoleColor.Yellow, ETipo.conBrillitos);

            Console.WriteLine(Tinta.Mostrar(tinta1));
            Console.WriteLine();
            Console.WriteLine(Tinta.Mostrar(tinta2));
            Console.WriteLine();
            Console.WriteLine(Tinta.Mostrar(tinta3));
            Console.WriteLine("\n------------\n");

            Tinta t = new Tinta();

            Console.WriteLine(t);
            Console.WriteLine("\n------------\n");

            if (t == tinta1)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("No son iguales");

            Console.WriteLine("\n------------\n");

            Pluma pluma1 = new Pluma("asdas", tinta2);
            Console.WriteLine(pluma1);
            Console.WriteLine();
            Console.WriteLine(Pluma.Mostrar(pluma1));

            Console.WriteLine("\n------------\n");

            if (pluma1 == tinta3)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("No son iguales");

            Console.WriteLine("\n------------\n");

            Pluma pluma2 = new Pluma("asdas", tinta2); 
            Pluma pluma3 = new Pluma("asdas", tinta3);

            if (pluma1 == pluma2)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("No son iguales");

            if (pluma1 == pluma3)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("No son iguales");

            Console.WriteLine("\n------------\n");

            pluma1 = pluma1 + pluma2;
            Console.WriteLine(pluma1);
            Console.WriteLine();

            pluma1 = pluma1 - pluma2;
            Console.WriteLine(pluma1);

            //Pluma pluma2;
            //pluma2 = pluma1 + tinta2;
            //Console.WriteLine(pluma2);
            //Console.WriteLine();

            //pluma1 = pluma1 - tinta2;
            //Console.WriteLine(pluma1);
            //Console.WriteLine();

            //pluma1 = pluma1 - tinta2;
            //Console.WriteLine(pluma1);
            //Console.WriteLine();

            //pluma1 = pluma1 - tinta2;
            //Console.WriteLine(pluma1);
            //Console.WriteLine();

            Console.ReadLine();
        }
    }
}
