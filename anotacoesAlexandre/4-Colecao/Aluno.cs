using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColecaoCSharp
{
    public class Aluno : IComparable<Aluno>
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Aluno(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override bool Equals(Object o) {
            if ((o == null) || !this.GetType().Equals(o.GetType())) {
                return false;
            } else {
                Aluno e = (Aluno) o;
                return (Id == e.Id && this.Nome == e.Nome);
            }
        }
        
        public override string ToString()
        {
            return "Aluno{" + "ID=" + Id + ", Nome=" + Nome + "}";
        }

        public override int GetHashCode()
        {
            //int hash = 3;
            //hash = 67 * hash + Codigo;
            //return hash;

            //return HashCode.Combine(Id, Nome);
            //return (Id.GetHashCode() ^ Nome.GetHashCode());

            //return Codigo.GetHashCode();

            return HashCode.Combine(Id);
        }
        

        public int CompareTo(Aluno? other)
        {
            if (this.Id < other.Id)
                return -1;
            if (this.Id == other.Id)
            {
                if (this.Nome.CompareTo(other.Nome) < 0)
                    return -1;
            }
            return 1;
        }        
    }
}
