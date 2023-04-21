using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkListBoxAlimentos.Items.Add("Carne");
            chkListBoxAlimentos.Items.Add("Pescado", true);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            chkListBoxAlimentos.Items.Add(txtNuevoAlimento.Text);
        }

        private void chkListBoxAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = chkListBoxAlimentos.SelectedIndex;
            if (indice != -1)
            {
                lblNombre.Text = chkListBoxAlimentos.Items[indice].ToString();
            }
            if (chkListBoxAlimentos.GetItemChecked(3) == true)
                MessageBox.Show("El pescado es muy bueno");
        }
    }
}
