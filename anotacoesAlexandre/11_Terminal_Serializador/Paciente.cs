using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _11_Terminal_Serializador
{
    [Serializable]
    public class Paciente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }

        public Paciente()
        {
        }

        public Paciente(string nome, string dataNascimento, string cpf)
        {
            this.Nome = nome;
            this.DataNascimento = DateTime.Parse(dataNascimento);
            this.Cpf = cpf;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + ". CPF: " + Cpf + ". Data Nascimento: " + DataNascimento;
        }

        public override bool Equals(object? obj)
        {
            return obj is Paciente pessoa &&
                   Cpf == pessoa.Cpf;
        }
    }
}
