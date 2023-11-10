using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms1
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;

            Email = Util.gerarEmail(nome);  
        }

        public override string ToString()
        {
            return Nome + "\t\t" + Email;
        }

        public override bool Equals(object? obj)
        {
            return obj is Pessoa pessoa && Email == pessoa.Email;
        }
    }
}
