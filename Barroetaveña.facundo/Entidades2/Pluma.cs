using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades2
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        #region Constructores

        public Pluma()
        {
            this._marca = "Sin marca";
            this._tinta = null;
            this._cantidad = 1;
        }

        public Pluma(string marca)
            : this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, Tinta tinta)
            : this(marca)
        {
            this._tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad)
            : this(marca, tinta)
        {
            this._cantidad = cantidad;
        }

        #endregion

        #region Metodos

        private string Mostrar()
        {
            return this._cantidad + " - " + this._marca + " - " +
                    Tinta.Mostrar(this._tinta);
        }

        public static string Mostrar(Pluma pluma)
        {
            return pluma.Mostrar();
        }


        #endregion

        #region Sobrecarga Operadores

        public static implicit operator string(Pluma t)
        {
            return t.Mostrar();
        }

        public static Boolean operator ==(Pluma pluma, Tinta tinta)
        {
            return tinta == pluma._tinta ? true : false;
        }

        public static Boolean operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        public static Boolean operator ==(Pluma p1, Pluma p2)
        {
            return p1._tinta == p2._tinta ? true : false;
        }

        public static Boolean operator !=(Pluma p1, Pluma p2)
        {
            return !(p1 == p2);
        }

        public static Pluma operator +(Pluma p, Tinta t)
        {
            if (p == t)
                p._cantidad++;

            return p;
        }

        public static Pluma operator -(Pluma p, Tinta t)
        {
            if (p == t)
                p._cantidad--;
            if (p._cantidad == 0)
                p._tinta = null;

            return p;
        }

        public static Pluma operator +(Pluma p1, Pluma p2)
        {
            if (p1 == p2)
                p1._cantidad++;

            return p1;
        }

        public static Pluma operator -(Pluma p1, Pluma p2)
        {
            if (p1 == p2)
                p1._cantidad--;
            //if (p1._cantidad == 0)
            //    p1._tinta = null;

            return p1;
        }

        #endregion

        //comparar plumas por tinta**
        //sumar dos plumas.cantidad si son iguales**
    }
}
