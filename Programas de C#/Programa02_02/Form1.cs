namespace Programa02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form2 miforma = new Form2();

            miforma.ShowDialog();
        }
    }
}