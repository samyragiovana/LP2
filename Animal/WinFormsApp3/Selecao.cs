namespace WinFormsApp3
{
    public partial class Selecao : Form
    {
        public Selecao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                animaloviparo form2 = new animaloviparo();
                form2.ShowDialog();
            }
            else
            {
                animalmamifero form3 = new animalmamifero();
                form3.ShowDialog();
            }
        }
    }
}