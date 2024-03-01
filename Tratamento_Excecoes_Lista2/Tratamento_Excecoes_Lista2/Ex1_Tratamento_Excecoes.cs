namespace Tratamento_Excecoes_Lista2
{
    public partial class Ex1_Tratamento_Excecoes : Form
    {
        public Ex1_Tratamento_Excecoes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int v1 = int.Parse(textBox1.Text);
                int v2 = int.Parse(textBox2.Text);

                int divisao = v1 / v2;
                   MessageBox.Show("O valor da divisão é de:" + divisao.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Valor indivisível!\n\n" + ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}