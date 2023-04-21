using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Font miFuente = new Font("Arial", 16.0f, FontStyle.Italic);

            //lblMensaje.Font = miFuente;
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                lblMensaje.Font = fontDialog1.Font;
            }
        }
    }
}
