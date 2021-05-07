using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class bienvenida : Form
    {
        public bienvenida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Primero ocultamos la ventana de bienvenida.
            this.Hide();

            //Al poner essta ventana como principal, y al ocultar la otra solo aparece esta.
            ventana_Principal ventana = new ventana_Principal();
            ventana.Show();
        }
    }
}
