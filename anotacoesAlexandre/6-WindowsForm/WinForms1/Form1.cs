namespace WinForms1
{
    public partial class Form_principal : Form
    {

        public Form_principal()
        {
            InitializeComponent();
        }

        private void colocarListaText(List<Pessoa> lista)
        {
            textBox_relacaoNomes.Text = "";
            listView_relacaoNomes.Items.Clear();
            foreach (var pessoa in lista)
            {
                textBox_relacaoNomes.AppendText(pessoa + Environment.NewLine);
                string[] itens = { pessoa.Nome, pessoa.Email };
                listView_relacaoNomes.Items.Add( new ListViewItem( itens ) );
            }
        }

        private void cadastrar()
        {
            string[] vetor = textBox_frase.Text.Split();
            if (vetor.Length >= 2)
            {
                //gerar o email

                string nome = textBox_frase.Text.ToUpper();
                Pessoa p = new Pessoa(nome);

                //verificar se p já existe
                if (!lista.Contains(p))
                {
                    lista.Add(p);
                    lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));

                    colocarListaText(lista);
                    textBox_frase.Text = "";
                }
            }
        }

        private void textBox_frase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                cadastrar();
            }
        }

        List<Pessoa> lista = new List<Pessoa>();

        private void button_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            lista.Clear();
            textBox_relacaoNomes.Clear();
            listView_relacaoNomes.Items.Clear();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema desenvolvido pela turma .Net 2023", "Sobre");
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            cadastrar();
        }
    }
}