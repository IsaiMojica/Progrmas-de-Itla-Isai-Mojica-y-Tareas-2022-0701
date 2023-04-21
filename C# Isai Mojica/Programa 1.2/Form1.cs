using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMensaje.Text = "";
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = txtNombre.Text + " espacio es el nombre, Hola! ";
        }
    }
}
