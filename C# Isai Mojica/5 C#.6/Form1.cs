using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_5._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ////Dibujamos elipse
            //g.DrawEllipse(Pens.Indigo, new Rectangle(50, 50, 100, 50));

            //// Dibujamos en coordenadas de mundo y pixeles
            //g.DrawEllipse(Pens.Red, new Rectangle(0, 0, 20, 20));

            ////Offset al origen
            //g.TranslateTransform(100, 100);

            //g.DrawEllipse(Pens.Blue, new Rectangle(0, 0, 20, 20));
            //g.DrawEllipse(Pens.CadetBlue, new Rectangle(20, 0, 20, 20));

            //Fin ejemplo 1

            //Ejemplo 2
            g.DrawEllipse(Pens.Red, new Rectangle(0, 0, 20, 20));

            g.PageUnit = GraphicsUnit.Inch;

            g.DrawEllipse(Pens.Blue, new Rectangle(1, 1, 20, 20));

            //Fin ejemplo 2
        }
    }
}
