using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Total = 0;

            if (chkMonitor.Checked == true)
                Total = Total + 390;

            if(chkTeclado.Checked == true)
                Total = Total + 400;

            if(chkMouse.Checked == true)
                Total = Total + 120;

            MessageBox.Show(" El total es " + Total.ToString());
        }

        private void chkMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonitor.Checked == true)
                lblMensaje.Text = "Monitor";
            else
                lblMensaje.Text = " ";
        }

        private void chkTeclado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTeclado.Checked == true)
                lblMensaje.Text = "Teclado";
            else
                lblMensaje.Text = " ";
        }

        private void chkMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMouse.Checked == true)
                lblMensaje.Text = "Mouse";
            else
                lblMensaje.Text = " ";


           
        }
        
    }
}
