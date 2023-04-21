using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_6._9
{
    public partial class MiBoton : Control
    {
        private bool presionado = false;
        private bool activado = false;
        public MiBoton()
        {
            InitializeComponent();
        }
        public bool Activado
        {
            get { return activado; }
            set
            {
                activado = value;
                Invalidate();
            }
        }
        // Hacemos un new a la propiedad Text
        public new string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint (pe);
            Graphics g = pe.Graphics;


            // Obtenemos el rectangulo que representa al area del control
            Rectangle rect = ClientRectangle;
            rect.Width--;
            rect.Height--;

            // Colocamos el color de fondo, en este caso el mismo que el padre
            g.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);

            // Coloco el fondo que voy a usar
            Color miColor;

            if (presionado == true)
                miColor = Color.Blue;
            else
                miColor = Color.Orange;


            g.FillEllipse(new SolidBrush(miColor), rect);

            // Coloco el text a desplegar
            Font fuente = new Font("Arial", (float)rect.Height * 0.5f, FontStyle.Regular);

            // Damos formato a la fuente
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            g.DrawString(Text, fuente, Brushes.Black, new Rectangle(rect.Left, rect.Top, rect.Width, rect.Height), formato);
            
            // Dibujamos info de la otra propiedad
            if (activado == true)
            g.FillEllipse(Brushes.Red, new Rectangle(rect.Left, rect.Top, 10, 10));
            else
                g.FillEllipse(Brushes.Gray, new Rectangle(rect.Left, rect.Top, 10, 10));
        }
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Que haga nada
            base.OnPaintBackground (pevent);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            //base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
                presionado = true;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            //base.OnMouseUp (e);
            if (e.Button == MouseButtons.Left)
                presionado = false;
            Invalidate();
        }

    }
}

