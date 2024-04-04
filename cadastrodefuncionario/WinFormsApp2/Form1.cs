namespace WinFormsApp2
{

    public partial class Form1 : Form
    {
        Empregado emp = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emp == null)
            {
                emp = new Empregado();
            }

            emp.Nome = Convert.ToString(textBox1.Text);
            emp.Idade = Convert.ToInt32(label3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = emp.Nome;
            label7.Text = emp.Idade.ToString();
            groupBox2.BackColor = Color.Turquoise;
        }
    }
}