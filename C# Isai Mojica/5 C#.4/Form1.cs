using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_5._4
{
    public partial class Form1 : Form
    {
        private Form2 forma;
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarVentana1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma == null)
            {
                forma = new Form2();
                forma.MdiParent = this;
                forma.FormClosed += new FormClosedEventHandler(CerrarForma);
                forma.Show();
            }
            else
            {
                forma.Activate();
            }
        }
        void CerrarForma(object sender, FormClosedEventArgs e)
        {
            forma = null;
        }
        private void adicionarVentana2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 otraForma = new Form3();
            otraForma.MdiParent = this;
            otraForma.Show();
        }
    }
}
