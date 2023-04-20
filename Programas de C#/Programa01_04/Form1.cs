namespace Programa01_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (chkMonitor.Checked == true)
                total = total + 250;

            if (ChkTeclado.Checked == true)
                total = total + 15;
            if (ChkMouse.Checked == true)
                total = total + 20;

            MessageBox.Show("El total es " + total.ToString());
        }

        private void chkMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonitor.Checked == true)
                lblMensaje.Text = "Monitor";
            else
                lblMensaje.Text = "";
        }

        private void ChkTeclado_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTeclado.Checked == true)
                lblMensaje.Text = "Teclado";
            else
                lblMensaje.Text = "";
        }

        private void ChkMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkMouse.Checked == true)
                lblMensaje.Text = "Mouse";
            else
                lblMensaje.Text = "";

        }
    }
}