using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades2
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipo _tipo;

        #region constructores

        public Tinta()
        {
            _color = ConsoleColor.Black;
            _tipo = ETipo.comun;
        }

        public Tinta(ConsoleColor color)
            : this()
        {
            _color = color;
        }

        public Tinta(ConsoleColor color, ETipo tipo)
            : this(color)
        {
            _tipo = tipo;
        }

        #endregion

        #region Metodos

        private string Mostrar()
        {
            return _color.ToString() + " - " + _tipo.ToString();
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        #endregion

        #region Sobrecarga Operadores

        public static Boolean operator ==(Tinta a, Tinta b)
        {
            return a._color == b._color && a._tipo == b._tipo ? true : false;
        }

        public static Boolean operator !=(Tinta a, Tinta b)
        {
            return !(a == b);
        }

        //public static explicit operator string(Tinta t)
        //{
        //    return t.Mostrar();
        //}

        public static implicit operator string(Tinta t)
        {
            return t.Mostrar();
        }

        #endregion

    }
}
