namespace Programa01_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double r = 0.0;
            double a = 0.0;
            double b = 0.0;

            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            if (rbSuma.Checked == true)
                r = a + b;

            if (rbResta.Checked == true)
                r = a - b;

            if (rbMulti.Checked == true)
                r = a * b;

            if (rbDivisión.Checked == true)
                r = a / b;

            lblResultado.Text = r.ToString();
        }
    }
}