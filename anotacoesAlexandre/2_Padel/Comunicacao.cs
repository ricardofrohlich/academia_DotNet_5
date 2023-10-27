namespace _2_Padel;

public class Comunicacao
{
    public static void cadastrarAtleta(List<Atleta> lista)
    {
        string nome;
        string email;
        DateOnly dataNascimento;
        string posicao;
        string categoria;

        Console.Write("Informe o email: ");
        email = Console.ReadLine();

        //lista de atletas
        //[{nome,email,dataNascimento,posicao,categoria}, {}, {}, {}]
        if (Atleta.estaContido(email,lista)) {
            Console.WriteLine("Email já utilizado no sistema!!");
        } else {
            //pedir o restante dos dados
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Data nascimento [dd/mm/aaaa]: ");
            dataNascimento = DateOnly.Parse(Console.ReadLine());
            Console.Write("Posição na quadra [direita ou esquerda]: ");
            posicao = Console.ReadLine();
            Console.Write("Categoria [1 ou 2 ou 3 ou 4 ou 5]: ");
            categoria = Console.ReadLine();

            //instanciar um objeto atleta
            Atleta atleta = new Atleta(nome, email, dataNascimento, posicao, categoria);

            //adicionar na lista
            lista.Add( atleta );
        }
    }

    public static void listarAtletas(List<Atleta> lista)
    {
        foreach (var atleta in lista) 
        {
            Console.WriteLine(atleta.sobrenome() + " - " + atleta.PosicaoQuadra + " - " + atleta.Categoria);
        }
    }

}
