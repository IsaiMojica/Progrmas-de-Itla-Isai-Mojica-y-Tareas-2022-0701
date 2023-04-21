using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_3._2
{
    public partial class Form1 : Form
    {
        private int indice;

        public Form1()
        {
            InitializeComponent();
            indice = 0;
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            indice++;
            if (indice > 5)
                indice = 0;
            lblFoto.ImageIndex = indice;

            picBImagen.Image = imgLFotos.Images[indice];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBImagen.Image = imgLFotos.Images[0];

        }
    }
}
