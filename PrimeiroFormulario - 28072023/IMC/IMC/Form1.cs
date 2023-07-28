namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class IMC
        {
            public double altura;
            public double peso;
            public double imc;

            public double CalculoIMC()
            {
                return this.peso / (this.altura * this.altura);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            IMC i = new();
            i.peso = Convert.ToDouble(textBox1.Text);
            i.altura = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(i.CalculoIMC());
            if (i.CalculoIMC() < 16.9)
            {
                MessageBox.Show("Muito abaixo do peso");
            } else if (i.CalculoIMC() < 18.4)
            {
                MessageBox.Show("Abaixo do peso");
            } else if (i.CalculoIMC() < 24.9)
            {
                MessageBox.Show("Peso normal");
            } else if (i.CalculoIMC() < 29.9)
            {
                MessageBox.Show("Acima do peso");
            } else if (i.CalculoIMC() < 34.9)
            {
                MessageBox.Show("Obesidade grau I");
            } else if (i.CalculoIMC() < 40)
            {
                MessageBox.Show("Obesidade grau II");
            } else
            {
                MessageBox.Show("Obesidade grau III");
            }
        }
    }
}