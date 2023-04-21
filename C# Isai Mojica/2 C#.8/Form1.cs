using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dupFrutas.Items.Add("Melon");
            dupFrutas.Items.Add("Pera");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dupFrutas.Items.Add(txtFruta.Text);

            txtFruta.Text = "";
        }

        private void dupFrutas_SelectedItemChanged(object sender, EventArgs e)
        {
            string fruta = (string)dupFrutas.SelectedItem;
            lblMensaje.Text = string.Format("Tu fruta favorita es (0), muy buena", fruta);

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int indice = dupFrutas.SelectedIndex;
            dupFrutas.Items.RemoveAt(indice);
            dupFrutas.SelectedIndex = 0;
        }
    }
}
