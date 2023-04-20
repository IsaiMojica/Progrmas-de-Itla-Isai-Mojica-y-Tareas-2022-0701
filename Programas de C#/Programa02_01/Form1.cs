namespace Programa02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola a todos");
            
            //MessageBox.Show("Hola a todos", "Mi MessageBox");

            DialogResult r = MessageBox.Show("Probamos botones", "Diferentes botones", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);

            if (r == DialogResult.Abort)
                lblMensaje.Text = "Omitir";
            if (r == DialogResult.Retry) ;
                lblMensaje.Text = "Reintentar";
            if (r == DialogResult.Ignore)
                lblMensaje.Text = "Ignorar";
        }
    }
}