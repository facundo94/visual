using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsCosa
{
    public partial class Calendario : Form
    {
        private Cosa cosa1;
        

        public Calendario()
        {
            InitializeComponent();
            this.Text += " ABM";
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            int entero = int.Parse(this.txtEntero.Text);
            string cadena = this.txtCadena.Text;
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);

            cosa1 = new Cosa(entero, cadena, fecha);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.cosa1.Mostrar(),"Atencion",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void txtEntero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
