using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_5._5
{
    public partial class Form1 : Form
    {
        private int x = 0;
        private int y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDibuja_Click(object sender, EventArgs e)
        {
            //Obtencion de objetos graficos por medio del handle de la ventana
            Graphics g = Graphics.FromHwnd(this.Handle);
            //Creacion de fuente
            Font fuente = new Font("Times New Roman", 35);
            //Dibujamos texto
            g.DrawString("En metodo", fuente, Brushes.Green, 50, 75);

                g.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Obtencion de objetos graficos
            Graphics g = e.Graphics;
            //Creacion de fuente
            Font fuente = new Font("Times New Roman", 35);
            //Dibujamos texto
            g.DrawString("Hola a todos", fuente, Brushes.Red, x, y);
        }

        private void btnInvalidate_Click(object sender, EventArgs e)
        {
            x += 5;
            y += 17;

            Invalidate(new Rectangle(0,0,100,120));
        }
    }
}
