using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades3
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;

        #region Constructores

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }

        #endregion

        #region Metodos

        private string Mostrar()
        {
            return this._color.ToString() + " - " + this._marca + " - " + this._cantidad;
        }

        public static string Mostrar(Tempera t)
        {
            return t.Mostrar();
        }
        
        public static Boolean NotNull(Tempera t)
        {
            Boolean retorno = false;

            if (!(Tempera.Equals(t,null)))
                retorno = true;
            
            return retorno;
        }

        #endregion

        #region Sobrecargas

        public static Boolean operator ==(Tempera a, Tempera b)
        {
            return a._color == b._color && a._marca == b._marca ? true : false;
        }

        public static Boolean operator !=(Tempera a, Tempera b)
        {
            return !(a == b);
        }

        public static explicit operator string(Tempera t)
        {
            return t.Mostrar();
        }

        public static implicit operator int(Tempera t)
        {
            return t._cantidad;
        }

        public static Tempera operator +(Tempera a, int b)
        {
            a._cantidad = a._cantidad + b;
            return a;
        }

        public static Tempera operator +(Tempera a, Tempera b)
        {
            if (a == b)
                a = a + b._cantidad;

            return a;
        }

        public static Tempera[] operator +(Tempera[] a, Tempera b)
        {
            int i = 0;

            foreach (Tempera item in a)
            {
                if(item == b)
                    a[i] = a[i] + b;
                i++;
            }

            return a;
        }

        public static Tempera operator -(Tempera a, Tempera b)
        {
            if (a == b)
                a._cantidad = a._cantidad - b._cantidad;

            if (a._cantidad <= 0)
                a = null;

            return a;
        }

        public static Tempera[] operator -(Tempera[] a, Tempera b)
        {
            int i = 0;

            foreach (Tempera item in a)
            {
                if (item == b)
                    a[i] = a[i] - b;
                i++;
            }

            return a;
        }

        #endregion

    }
}
