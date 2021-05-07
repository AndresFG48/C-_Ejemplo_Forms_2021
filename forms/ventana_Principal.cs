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
    public partial class ventana_Principal : Form
    {
        public ventana_Principal()
        {
            InitializeComponent();
        }

        //Metodo para cerrar la aplicación entera cuando se cierra el form.
        protected override void OnFormClosing (FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventana1 venta = new ventana1();
            venta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventana2 venta = new ventana2();
            venta.Show();
        }
    }
}
