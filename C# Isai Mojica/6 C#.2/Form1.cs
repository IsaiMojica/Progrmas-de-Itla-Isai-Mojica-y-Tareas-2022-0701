using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            Console.Beep();

            if (((Button)sender).Name == "btnUno")
                MessageBox.Show("Es el boton uno");

            if (((Button)sender).Name == "btnDos")
                lblMensaje.Text = ("Se oprimio boton dos");
            
            if (((Button)sender).Name == "btnTres")
            {
                lblMensaje.Text = ((Button)sender).Text;
                ((Button)sender).Text = "Oprimido";
            }
            

        }
    }
}
