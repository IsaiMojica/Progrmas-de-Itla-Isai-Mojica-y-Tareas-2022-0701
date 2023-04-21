using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_1._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola a todos");
            //MessageBox.Show("Hola a todos","Mi MesageBox");

            DialogResult r= MessageBox.Show("Probando btones", "Diferentes botones", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Information);
            
            if (r == DialogResult.Abort)
                lblMensaje.Text = "Anular";
            if (r == DialogResult.Retry)
                lblMensaje.Text = "Reintentar";
            if (r == DialogResult.Ignore)
                lblMensaje.Text = "Omitir";


        }
    }
}
