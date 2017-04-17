using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cosa
    {
        #region atributos
        public int entero;
        public string cadena;
        public DateTime fecha;
        #endregion

        #region Cosntructores
        public Cosa() 
        {
            this.entero = (10);
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(string cadena) : this()
        {
            this.cadena = cadena;
        }

        public Cosa( string cadena, DateTime fecha) :this(cadena)
        {
            this.fecha = fecha;
        }
        
        public Cosa(int entero, string cadena, DateTime fecha) :this(cadena, fecha)
        {
            this.entero = entero;
            this.SetValor(cadena);
            this.SetValor(fecha);
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            return this.entero + " - " + this.cadena+ " - " + this.fecha;
        }

        public void SetValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void SetValor(int entero)
        {
            this.entero = entero;
        }

        public void SetValor(DateTime fecha)
        {
            this.fecha = fecha;
        }
        #endregion
    }
}
