using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtContenido_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void txtContenido_DragDrop(object sender, DragEventArgs e)
        {
            txtContenido.Text = "";

            //Arreglos de los archivos
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string linea = "";

            lblArchivo.Text = archivos[0];

            //Leer archivo
            StreamReader lector = File.OpenText(archivos[0]);

            while ((linea = lector.ReadLine()) != null)
            {
                txtContenido.Text += linea + "\r\n";
            }

            lector.Close();
        }
    }
}
