namespace _17_WinFormsApp_SerializadorJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Paciente> pacientes = new List<Paciente>();

        private bool saoValidosCampos()
        {
            return !textBox_nomePaciente.Text.Equals("") && !textBox_dataNascimento.Text.Equals("") && !textBox_cpf.Text.Equals("");
        }

        private void limpaCampos()
        {
            textBox_nomePaciente.Text = String.Empty;
            textBox_dataNascimento.Text = String.Empty;
            textBox_cpf.Text = String.Empty;
        }

        private void button_gravar_Click(object sender, EventArgs e)
        {
            if (saoValidosCampos())
            {
                try
                {
                    Paciente p = new Paciente(textBox_nomePaciente.Text.ToUpper(), DateTime.Parse(textBox_dataNascimento.Text), textBox_cpf.Text);
                    if (Paciente.jaCadastrado(pacientes, p.Nome))
                    {
                        MessageBox.Show("Paciente já cadastrado", "Alerta");
                    }
                    else
                    {
                        pacientes.Add(p);
                        MessageBox.Show("Paciente cadastrado com sucesso", "Alerta");
                    }

                    limpaCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Data inválida", "Alerta");
                }
                
            } else
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos", "Alerta");
            }
        }

        private void button_serializar_Click(object sender, EventArgs e)
        {
            if (pacientes.Count > 0)
            {
                Serializador.serializarJSON(pacientes, @"C:\teste\pacientes.json");
                textBox_conteudoArquivo.Text = Arquivo.lerArquivo(@"C:\teste\pacientes.json");
            } else
            {
                MessageBox.Show("Lista de pacientes vazia!","Alerta");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serializador.deserializarJSON(pacientes, @"C:\teste\pacientes.json");
        }
    }
}