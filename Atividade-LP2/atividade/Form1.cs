namespace atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circulo1 f = new Circulo1();
            f.ShowDialog();
            Circulo circulo = new Circulo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Retangulo1 f = new Retangulo1();
            f.ShowDialog();
            Retangulo retangulo = new Retangulo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Triangulo1 f = new Triangulo1();
            f.ShowDialog();
            Triangulo triangulo = new Triangulo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
