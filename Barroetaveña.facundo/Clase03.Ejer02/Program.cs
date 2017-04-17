using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.Ejer02
{
    using AutoPartes;
    using Autos;

    class Program
    {
        static void Main(string[] args)
        {
            /*Rueda rueda1 = new Rueda();
            Rueda rueda2 = new Rueda();
            Rueda rueda3 = new Rueda();*/

           /* rueda1.marca = "Firestone";
            rueda1.tamaño = 165;
            rueda2.marca = "GoodYear";
            rueda2.tamaño = 175;*/

            /*Console.WriteLine(rueda1.Mostrar());
            Console.WriteLine(rueda2.Mostrar());
            Console.WriteLine(rueda3.Mostrar());
            */

            /*Auto auto1 = new Auto();
            Auto auto2 = new Auto();
            Auto auto3 = new Auto();
            Auto auto4 = new Auto();
            Auto auto5 = new Auto();*/

            /*Console.WriteLine("TD {0}", auto1.TD.Mostrar());
            Console.WriteLine("TI {0}", auto1.TI.Mostrar());
            Console.WriteLine("DD {0}", auto1.DD.Mostrar());
            Console.WriteLine("DI {0}", auto1.DI.Mostrar());
            Console.ReadLine();*/

            /*Console.WriteLine(auto1.MostrarAuto());
            Console.WriteLine(auto2.MostrarAuto());
            Console.WriteLine(auto3.MostrarAuto());
            Console.WriteLine(auto4.MostrarAuto());
            Console.WriteLine(auto5.MostrarAuto());
            Console.ReadLine();*/

            Carrera nuevaCarrera = new Carrera();
            int i;

            for (i = 0; i < 5; i++)
            {
                nuevaCarrera.PorTiempo(i);
            }

            Console.WriteLine(nuevaCarrera.MostrarCarrera());
            Console.ReadLine();
            
        }
    }
}
