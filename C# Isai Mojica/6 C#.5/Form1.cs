using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_6._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            //Navegamos al URL en el Txt
            webBrowser1.Navigate(txtURL.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Volver a la pagina anterior
            webBrowser1.GoBack();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Ir a la pag siguiente
            webBrowser1.GoForward();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            //Recargamos la pagina
            webBrowser1.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //Detener la carga de la pagina
            webBrowser1.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
