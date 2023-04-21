using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_1._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0.0;
            string cotizacion = "";
             
            cotizacion = "cotizacion de auto para" + txtNombre.Text + "\r\n";

            // Obtener costo inicial
            costo = Convert.ToDouble(txtCosto.Text);

            // Verificar seguro
            if (rbnBasico.Checked == true)
            {
                costo = costo + 500.0;
                cotizacion += "Lleva seguro basico de $500 \r\n";
            }
            if(rbnTerceros.Checked == true)
            {
                costo += 700.0;
                cotizacion += "Lleva seguro de terceros $700 \r\n";
            }
            if (rbnTotal.Checked == true)
            {
                costo += 1000.0;
                cotizacion += "Lleva seguro total de $1000 \r\n";
            }

            // Verificar equipo 

            if (chkAire.Checked == true)
            {
                costo += 500.0;
                cotizacion += "Con aire acondicionado de 500 \r\n";
            }

            if (chkAudio.Checked == true)
            {
                costo += 700.0;
                cotizacion += "Con Sistema de Audio de 700 \r\n";
            }

            // Mostramos total

            cotizacion += "El total a pagar es de" + costo.ToString();

            txtCotizacion.Text = cotizacion;

        }
    }
}
