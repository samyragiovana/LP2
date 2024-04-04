namespace Atividade_3
{
    public partial class Botoes : Form
    {
        public Botoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoje é quarta-feira dia 15/03/2022");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            raiz f = new raiz();
            f.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            retangulo r = new retangulo();
            r.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bhaskara b = new bhaskara();
            b.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            maior m = new maior();
            m.ShowDialog();
        }

        private void Botoes_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            areaCirculo ac = new areaCirculo();
            ac.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            km km = new km();
            km.ShowDialog();
        }
    }
}