using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades3
{
    public class Paleta
    {
        private Tempera[] _temperas;
        private int _cantMaxColores;

        #region Constructores

        private Paleta() : this(5) { }

        public Paleta(int cant)
        {
            this._cantMaxColores = cant;
            this._temperas = new Tempera[cant];
        }

        #endregion

        #region Metodos

        private string Mostrar()
        {
            string retorno = "";

            foreach (Tempera t in this._temperas)
	        {
		        retorno = retorno + "\n" + (string)t;
	        }

            return retorno;
        }

        public void Agregar(Tempera t, int i)
        {
            this._temperas.SetValue(t, i);
        }

        private int ObtenerIndice()
        {
            return ObtenerIndice(null);
        }

        private int ObtenerIndice(Tempera t)
        {
            int i = 0;
            int retorno = -1;

            foreach (Tempera item in this._temperas)
            {
                if (!(Tempera.NotNull(t)) && !(Tempera.NotNull(item)))
                {
                    retorno = i;
                    break;
                }
                else if ((Tempera.NotNull(t)) && (item == t))
                {
                    retorno = i;
                    break;
                }

                i++;
            }

            return retorno;
        }


        //public Boolean NotNull(Paleta a)
        //{
        //    Boolean retorno = false;

        //    if (!(a.Equals(null))) 
        //    {
        //        foreach (Tempera item in a._temperas)
        //        {
        //            if (item.NotNull()) { }
        //        }
                
        //    }

        //    return retorno;
        //}

        #endregion

        #region Sobrecargas

        public static implicit operator Paleta(int a)
        {
            return new Paleta(a);
        }

        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }

        public static Boolean operator ==(Paleta p, Tempera t)
        {
            Boolean retorno = false;

            foreach (Tempera item in p._temperas)
            {
                if ((Tempera.NotNull(item)) && (Tempera.NotNull(t)) && (item == t))
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static Boolean operator !=(Paleta p, Tempera t)
        {          
            return !(p == t) ? true : false;
        }

        public static Paleta operator +(Paleta p, Tempera t)
        {
            int indice;

            if (!(p == t))
            {
                indice = p.ObtenerIndice();

                if(indice != -1)
                    p._temperas[indice] = t;
            }
            else
                p._temperas = p._temperas + t;

            return p;
        }

        public static Paleta operator -(Paleta p, Tempera t)
        {
            if (p == t)
                p._temperas = p._temperas - t;

            return p;
        }

        public static Paleta operator +(Paleta a, Paleta b)
        {
            int cantTemp = a._temperas.GetLength(0) + b._temperas.GetLength(0);
            int i;
            Tempera[] auxTemp = new Tempera[cantTemp];
            Paleta retorno;

            for (i = 0; i <= a._temperas.GetLength(0); i++)
            {
                auxTemp = auxTemp + a._temperas[i];
            }

            for (i = 0; i <= a._temperas.GetLength(0); i++)
            {
                auxTemp = auxTemp + b._temperas[i];                
            }

            cantTemp = auxTemp.GetLength(0);
            retorno = new Paleta(cantTemp);
            retorno._temperas = (Tempera[])auxTemp.Clone();

            return retorno;
        }

        
        #endregion

        #region Indexador

        public Tempera this[int indice]
        {
            get
            {
                if (indice >= this._temperas.GetLength(0) || indice < 0)
                    return null;
                else
                    return this._temperas[indice];
            }
            set
            {
                if (indice >= 0 && indice < this._temperas.GetLength(0))
                    this._temperas[indice] = value;
                else if (indice == this._temperas.GetLength(0))
                {

                    this._temperas = this + indice;
                    this[indice] = value;
                }
                else
                {
                    Console.WriteLine("No se puede asignar a este elemento");
                    Console.ReadLine();
                }
            }
        }

        public static Tempera[] operator +(Paleta paleta, int indice)
        {
            int i = indice >= paleta._temperas.GetLength(0) ? ++indice : --indice;

            Tempera[] aux = new Tempera[i];

            paleta._temperas.CopyTo(aux, 0);

            return aux;

        }
        #endregion

    }
}
