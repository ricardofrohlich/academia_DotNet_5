using System.Data;

namespace WF_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();

            dt = bd.executaConsulta("select * from pessoas");

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txbNome.Text;
            p.idade = int.Parse(txbIdade.Text);

            if(p.gravar())
            {
                MessageBox.Show("Cadastrado com sucesso!");

                button1_Click(null, null);
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar!");
            }
        }
    }
}