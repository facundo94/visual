using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroetaveña.facundo.Ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i;
            int max = 0;
            int min = 0;
            int suma = 0;
            float promedio;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                num = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    max = num;
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }

                if (num < min)
                {
                    min = num;
                }

                suma = suma + num;
            }
            promedio = suma / i;

            Console.WriteLine("El max: {0}, el min {1}, suma {2}, promedio{3}",max,min,suma,promedio);
            Console.ReadLine();
        }
    }
}
