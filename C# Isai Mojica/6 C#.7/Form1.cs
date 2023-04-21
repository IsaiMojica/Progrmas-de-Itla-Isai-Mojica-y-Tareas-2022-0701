using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_6._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                txtDos.Text = Clipboard.GetText();
            if (Clipboard.ContainsImage())
                    pictureBox1.Image = Clipboard.GetImage();
            if (Clipboard.ContainsData(DataFormats.Rtf))
            rtbUno.Rtf = (string) Clipboard.GetData(DataFormats.Rtf);
        }
        

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtUno.Text);
            Clipboard.SetImage (pictureBox1.Image);
            Clipboard.SetData (DataFormats. Rtf, rtbUno.Rtf);
        }
        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        Clipboard.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rtbUno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
