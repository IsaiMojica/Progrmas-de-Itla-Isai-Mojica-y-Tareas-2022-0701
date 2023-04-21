using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_2._4
{
    public partial class Form1 : Form
    {
        private int conteo;
        public Form1()
        {
            InitializeComponent();
            conteo = 0;
        }

        private void tmrPrueba_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblValor.Text = conteo.ToString();

            if (pbTrabajo.Value < 100)
                pbTrabajo.Value++;
            if (pbTrabajo.Value == 100)
                tmrPrueba.Enabled = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //tmrPrueba.Enabled = true;
            tmrPrueba.Start();
            pbTrabajo.Value = 0;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            //tmrPrueba.Enabled = false;
            tmrPrueba.Stop();
            trkIntervalo.Value = trkIntervalo.Minimum;

            lblTrkValor.Text = trkIntervalo.Value.ToString();
            tmrPrueba.Interval = trkIntervalo.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //tmrPrueba.Enabled = false;
            tmrPrueba.Stop();
        }

        private void trkIntervalo_Scroll(object sender, EventArgs e)
        {
            lblTrkValor.Text = trkIntervalo.Value.ToString();
            tmrPrueba.Interval = trkIntervalo.Value;
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < 100000; n++)

                //codigo de proceso

                if (n % 1000 == 0)
                    pbTrabajo.PerformStep();
        }
    }
}
