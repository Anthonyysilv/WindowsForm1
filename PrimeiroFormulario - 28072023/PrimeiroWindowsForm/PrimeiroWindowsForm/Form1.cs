namespace PrimeiroWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Calcular
        {
            public double valor1;
            public double valor2;
            public double resultado;

            public double Soma()
            {
                return this.valor1 + this.valor2;
            }
            public double Subtrair()
            {
                return this.valor1 - this.valor2;
            }
            public double Multiplicar()
            {
                return this.valor1 * valor2;
            }
            public double Dividir()
            {
                return this.valor1 / this.valor2;
            }
        }
        //Soma
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //Subtração
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //Multiplicação
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        //Divisão
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Botões
        //soma
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Referenciando a classe
            Calcular c = new Calcular();
            //Chamando e utilizando a classe e o método
            c.valor1 = Convert.ToDouble(textBox1.Text);
            c.valor2 = Convert.ToDouble(textBox2.Text);
            //Convertendo o resultado em texto para que ele apareça na terceira caixa de texto
            textBox3.Text = Convert.ToString(c.Soma());
        }
        //subtração
        private void button2_Click(object sender, EventArgs e)
        {
            Calcular c = new Calcular();
            c.valor1 = Convert.ToDouble(textBox6.Text);
            c.valor2 = Convert.ToDouble(textBox5.Text);
            textBox4.Text = Convert.ToString(c.Subtrair());
        }
        //multiplicação
        private void button3_Click_1(object sender, EventArgs e)
        {
            Calcular c = new Calcular();
            c.valor1 = Convert.ToDouble(textBox9.Text);
            c.valor2 = Convert.ToDouble(textBox8.Text);
            textBox7.Text = Convert.ToString(c.Multiplicar());
        }
        //divisão
        private void button4_Click_1(object sender, EventArgs e)
        {
            Calcular c = new Calcular();
            c.valor1 = Convert.ToDouble(textBox12.Text);
            c.valor2 = Convert.ToDouble(textBox11.Text);
            textBox10.Text = Convert.ToString(c.Dividir());
        }
    }
}