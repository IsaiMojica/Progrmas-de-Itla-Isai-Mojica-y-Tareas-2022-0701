namespace Programa02_03
{
    public partial class Form1 : Form
    {
        Form2 miForma2 = new Form2("Saludos");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnvio1_Click(object sender, EventArgs e)
        {
            //Creamos la instancia de la forma 2
           
            miForma2.Comentario = txtMensaje.Text;

            //Mostramos la forma
            miForma2.ShowDialog();
        }

        private void btnEnvio2_Click(object sender, EventArgs e)
        {
            miForma2.Comentario = txtMensaje.Text;
        }
    }
}