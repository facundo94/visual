using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

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

        public Cosa( string cadena, DateTime fecha)
        {
            this.SetValor(10);
            this.SetValor(cadena);
            this.SetValor(fecha);
        }
        
        public Cosa(int entero, string cadena, DateTime fecha)
        {
            this.entero = (entero);
            this.SetValor(cadena);
            this.SetValor(fecha);
        }

        public string Mostrar()
        {
            return this.entero + "-" + this.cadena+ "-" + this.fecha+"\n";
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
    }
}
