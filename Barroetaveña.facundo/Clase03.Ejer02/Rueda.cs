using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartes
{
    class Rueda
    {
        public string marca;
        public int tamaño;

        public string Mostrar()
        {
            return this.marca + " - " + this.tamaño;
        }

        public Rueda()
        {
            this.marca = "Sin marca";
            this.tamaño = 165;
        }

    }
}
