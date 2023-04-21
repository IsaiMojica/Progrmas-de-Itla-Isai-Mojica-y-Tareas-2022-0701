using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_2._7
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Adicion de renglon
            int n = dtgvPoductos.Rows.Add();

            //Colocacion de informacion
            dtgvPoductos.Rows[n].Cells[0].Value = txtCodigo.Text;
            dtgvPoductos.Rows[n].Cells[1].Value = txtNombre.Text;
            dtgvPoductos.Rows[n].Cells[2].Value = txtPrecio.Text;

            //Limpieza de los txt
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void dtgvPoductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                lblInfo.Text = (string)dtgvPoductos.Rows[n].Cells[1].Value;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvPoductos.Rows.RemoveAt(n);
            }
        }
    }
}
