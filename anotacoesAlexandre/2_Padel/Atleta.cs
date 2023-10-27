namespace _2_Padel;

public class Atleta : Pessoa
{   
    public string PosicaoQuadra {set;get;}
    public string Categoria {set;get;}

    public Atleta(string nome, string email, DateOnly data, string posicao, string categoria) : base(nome, email, data)
    {
        this.PosicaoQuadra = posicao;
        this.Categoria = categoria;  
    }

    public static bool estaContido(string email, List<Atleta> lista) 
    {
        foreach (var atleta in lista) 
        {
            if (email == atleta.Email)
            {
                return true;
            }
        }
        return false;
    }

}



