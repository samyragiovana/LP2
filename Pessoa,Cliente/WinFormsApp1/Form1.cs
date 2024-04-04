namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Id = textBox4.Text;
            p.Nome = textBox1.Text;
            p.Idade = Convert.ToInt32(textBox5.Text);
            p.Cpf = textBox3.Text;
            MessageBox.Show(
            "ID: " + p.Id + "\n"
            + "Nome: " + p.Nome + '\n'
            + "CPF: " + p.Cpf + "\n"
            + "Idade: " + p.Idade
            );


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            int x = Convert.ToInt32(textBox2.Text);
            c.comprar(x);
        }
    }
}