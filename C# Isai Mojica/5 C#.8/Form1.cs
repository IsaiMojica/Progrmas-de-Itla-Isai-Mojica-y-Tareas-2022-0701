using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_5._8
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

            //Pluma 1
            
            Pen pluma1 = new Pen(Color.Green, 5);
            g.DrawLine(pluma1, 50, 50, 200, 50);

            //Pluma con estilo de guion predeterminado

            Pen pluma2 = new Pen(Color.Red, 7);
            pluma2.DashStyle = DashStyle.DashDotDot;
            g.DrawLine(pluma2, 50, 70, 20, 70);

            //Estilo de guion
            Pen pluma3 = new Pen(Color.Orange, 10);
            float[] guiones = { 1.0f, 1.0f, 2.0f, 1.0f, 3.0f, 1.0f };

            pluma3.DashPattern = guiones;
            g.DrawLine(pluma3, 50, 90, 200, 90);

            //Terminal
            Pen pluma4 = new Pen(Color.DarkOrange, 15);
            pluma4.StartCap = LineCap.RoundAnchor;
            pluma4.EndCap = LineCap.RoundAnchor;
            g.DrawLine(pluma4, 50, 120, 200, 120);

        }
    }
}
