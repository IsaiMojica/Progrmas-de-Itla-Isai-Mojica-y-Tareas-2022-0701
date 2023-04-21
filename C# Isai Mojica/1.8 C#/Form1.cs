using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_1._8
{
    public partial class Form1 : Form
    {
        Form2 miforma2 = new Form2("Saludos");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnvio1_Click(object sender, EventArgs e)
        {
            //Se crea la instancia para la forma 2
            

            miforma2.Comentario = txtMensaje.Text;

            //Se muestra la forma
            miforma2.Show();
        }

        private void btnEnvio2_Click(object sender, EventArgs e)
        {
            miforma2.Comentario = txtMensaje.Text;
        }
    }
}
