using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_5._9
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

            ///Curva cerrada y rellena con la brocha
            Point[] puntos = { new Point(30, 45), new Point(110, 75), new Point(175, 200), };
            g.FillClosedCurve(Brushes.Aquamarine, puntos);

            ///Elipse rellena
            g.FillEllipse(Brushes.BlueViolet, new Rectangle(75, 30, 100, 25));

            ///Grafica de pie rellena
            g.FillPie(Brushes.Blue, new Rectangle(100, 100, 100, 100),45, 120);

            ///Dibujamos poligono relleno
            Point[] puntos2 = { new Point(20, 145), new Point(150, 75), new Point(200, 220), };
            g.FillPolygon(Brushes.DarkKhaki, puntos2);

            ///Dibujamos rectangulo relleno
            g.FillRectangle(Brushes.DarkOliveGreen, new Rectangle(150, 100, 30, 75));

            g.DrawRectangle(Pens.Red, new Rectangle(150, 100, 30, 75));
        }
    }
}
