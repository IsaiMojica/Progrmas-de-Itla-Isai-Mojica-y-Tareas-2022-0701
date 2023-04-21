using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Programa_5._1.Properties;

namespace Programa_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMensaje.Text = (string)Settings.Default["Mensaje"];

            chkImportado.Checked = (bool)Settings.Default["Importado"];
            chkOrganico.Checked = (bool)Settings.Default["Organico"];

            this.Size = (Size)Settings.Default["Tamano"];

            switch((int)Settings.Default["Frutas"])
            {
                case 0:
                    rbManzana.Checked = true;
                    rbPera.Checked = false;
                    rbUva.Checked = false;
                    break;
                case 1:
                    rbManzana.Checked = false;
                    rbPera.Checked = true;
                    rbUva.Checked = false;
                    break;
                case 2:
                    rbManzana.Checked = false;
                    rbPera.Checked = false;
                    rbUva.Checked = true;
                    break;
            }
        }

        private void txtMensaje_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["Mensaje"] = txtMensaje.Text;
            Settings.Default.Save();
        }

        private void chkImportado_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["Importado"] = chkImportado.Checked;
            Settings.Default.Save();
        }

        private void chkOrganico_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default["Organico"] = chkOrganico.Checked;
            Settings.Default.Save();
        }

        private void chkImportado_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default["Importado"] = chkImportado.Checked;
            Settings.Default.Save();
        }

        private void chkOrganico_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default["Organico"] = chkOrganico.Checked;
            Settings.Default.Save();
        }

        private void rbManzana_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManzana.Checked == true)
            {
                Settings.Default["Frutas"] = 0;
                Settings.Default.Save();
            }
        }

        private void rbPera_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPera.Checked == true)
            {
                Settings.Default["Frutas"] = 1;
                Settings.Default.Save();
            }
        }

        private void rbUva_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUva.Checked == true)
            {
                Settings.Default["Frutas"] = 2;
                Settings.Default.Save();
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {          
                Settings.Default["Tamano"] = this.Size;
                Settings.Default.Save();
        }
    }
}
