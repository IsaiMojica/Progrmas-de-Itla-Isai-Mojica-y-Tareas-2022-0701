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

namespace Programa_3._3
{
    public partial class Form1 : Form
    {
        private ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Center);
        private ListViewGroup carnes = new ListViewGroup("carnes", HorizontalAlignment.Center);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ImageList
            ImageList misImagenes = new ImageList();
           misImagenes.ImageSize = new Size(100, 100);

            //Obtener enlistado de imagenes
           string[] archivos = Directory.GetFiles("imagenes");

            //Cargamos los archivos
           try
           {
                foreach (string archivo in archivos)
                    misImagenes.Images.Add(Image.FromFile(archivo));

           }
            catch
           {
               MessageBox.Show("Algo salio mal al cargar");
           }


            lsvAlimentos.SmallImageList = misImagenes;

            lsvAlimentos.Items.Add(new ListViewItem("Manzana", frutas));
            lsvAlimentos.Items.Add(new ListViewItem("Pera", frutas));
            lsvAlimentos.Items.Add(new ListViewItem("Melon", frutas));
            lsvAlimentos.Items.Add(new ListViewItem("Banana", frutas));
            lsvAlimentos.Items.Add(new ListViewItem("Fresa", frutas));
           

            ListViewItem miElemento = new ListViewItem("Pollo", carnes);
            lsvAlimentos.Items.Add(miElemento);

            lsvAlimentos.Items.Add(new ListViewItem("Res", carnes));
            lsvAlimentos.Items.Add(new ListViewItem("Pescado", carnes));
            lsvAlimentos.Items.Add(new ListViewItem("Cerdo", carnes));
            lsvAlimentos.Items.Add(new ListViewItem("Codorniz", carnes));

            lsvAlimentos.Groups.Add(frutas);
            lsvAlimentos.Groups.Add(carnes);



        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (rbtFrutas.Checked == true)
            {
                lsvAlimentos.Items.Add(new ListViewItem(txtElemento.Text, frutas));
            }
            if (rbtCarnes.Checked == true)
            {
                lsvAlimentos.Items.Add(new ListViewItem(txtElemento.Text, carnes));
            }
        }

        private void lsvAlimentos_MouseClick(object sender, MouseEventArgs e)
        {
            lblSeleciondo.Text = lsvAlimentos.SelectedItems[0].SubItems[0].Text;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lsvAlimentos.Items.Clear();
            lblSeleciondo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsvAlimentos.Items.RemoveAt(lsvAlimentos.SelectedIndices[0]);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lsvAlimentos.SelectedItems[0].SubItems[0].Text = txtElemento.Text;
            lsvAlimentos.SelectedItems[0].ImageIndex = Convert.ToInt32(txtImagen.Text);

        }
    }
}
