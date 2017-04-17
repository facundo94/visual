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

            float numero;
            float max = 0;
            float min = 0;
            float suma = 0;
            float promedio = 0;
            int i;

            for (i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Ingrese un numero:");
                numero = float.Parse(Console.ReadLine());

                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }

                if (numero > max)
                {
                    max = numero;
                }

                if (numero < min)
                {
                    min = numero;
                }

                suma = suma + numero;
                
            }
            promedio = suma / i;

            Console.WriteLine("El numero maximo fue {0}, el minimo {1}, la suma de los numeros {2} y el promedio {3}", max, min, suma, promedio);

            Console.ReadLine();



        }
    }
}
