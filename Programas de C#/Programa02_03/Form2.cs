using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_03
{
    public partial class Form2 : Form
    {

        private string comentario;
        public Form2(string pMensaje)
        {
            InitializeComponent();

            lblMensaje.Text = pMensaje;
        }
        
        public string Comentario
        {
            set
            {
                Comentario = value;
                lblComentario.Text = comentario;
            }
        }
    }
}
