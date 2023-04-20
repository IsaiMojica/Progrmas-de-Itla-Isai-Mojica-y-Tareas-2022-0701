namespace Programa02_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForma2_Click(object sender, EventArgs e)
        {
            Form2 miForma2 = new Form2();
            DialogResult resultado = miForma2.ShowDialog();

            if(miForma2.ShowDialog()==DialogResult.OK);
            {
                lblMensaje.Text = miForma2.Mensaje;
                lblContenido.Text = miForma2.Contenido;
            }
            if(resultado==DialogResult.Cancel)
            {
                MessageBox.Show("No ejecutaste la operación");
            }
        }
    }
}