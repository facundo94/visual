using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02.Ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rueda rueda1 = new Rueda();
            Rueda rueda2 = new Rueda();

            rueda1.marca = "Firestone";
            rueda1.tamaño = 165;
            rueda2.marca = "GoodYear";
            rueda2.tamaño = 175;

            Console.WriteLine(rueda1.Mostrar());
            Console.WriteLine(rueda2.Mostrar());
            Console.ReadLine();
        }
    }
}
