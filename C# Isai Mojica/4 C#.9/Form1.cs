using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_4._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirNotepad_Click(object sender, EventArgs e)
        {
            //Permite recibir eventos del notepad
            prcNotepad.EnableRaisingEvents = true;

            //Arrancamos el proces
            prcNotepad.Start();

            lblEstado.Text = "Notepad arrancado";
        }

        private void btnCerrarNotepad_Click(object sender, EventArgs e)
        {
            prcNotepad.Kill();
        }

        private void prcNotepad_Exited(object sender, EventArgs e)
        {
            
            //Evento de cuando se cierra la forma
            lblEstado.Text = "Notepad cerrado";

            notifyIcon1.ShowBalloonTip(100, "Alert", "Notepad cerrado", ToolTipIcon.Info);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Mostrar la forma
            this.Show();
        }

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Esconder la forma 
            this.Hide();
        }
    }
}
