using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    using AutoPartes;

    class Auto
    {
        public static int contadorDeObjetos;
        private int kilometrosRecorridos;
        public Rueda DD;
        public Rueda DI;
        public Rueda TD;
        public Rueda TI;
        private eFabricante fabricante;
        private static Random rnd;

        /*public string MostrarAuto()
        {
            return this.fabricante + "\nTD " + this.TD.Mostrar() + "\nTI " + this.TI.Mostrar() + "\nDD " + this.DD.Mostrar() + "\nDI " + this.DI.Mostrar()+"\n\n";
        }*/

        public string MostrarAuto()
        {
            return Enum.GetName(typeof(eFabricante),this.fabricante);
        }

        static Auto()
        {
            Auto.contadorDeObjetos = 0;
            Auto.rnd = new Random();
        }

        public Auto()
        {
            this.DD = new Rueda();
            this.DI = new Rueda();
            this.TD = new Rueda();
            this.TI = new Rueda();
            this.kilometrosRecorridos = 0;
            this.fabricante = (eFabricante)Enum.ToObject(typeof(eFabricante), rnd.Next(0, 3));
            Auto.contadorDeObjetos++;
        }

        public void setKilometrosRecorridos(int kilometrosRecorridos)
        {
            this.kilometrosRecorridos += kilometrosRecorridos;
        }

        public int getKilometrosRecorridos()
        {
            return this.kilometrosRecorridos;
        }

        public void volveACero()
        {
            this.kilometrosRecorridos = 0;
        }
    }
}
