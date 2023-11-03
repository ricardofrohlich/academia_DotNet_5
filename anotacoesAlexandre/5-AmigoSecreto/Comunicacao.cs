namespace _5_AmigoSecreto;

public class Comunicacao
{
    public static void cadastrarPessoa(List<Pessoa> lista)
    {
        string nome;
        string email;

        do
        {
            Console.Write("Informe um email válido: ");
            email = Console.ReadLine();
        } while (!Utilidades.EmailIsValid(email));

        Console.Write("Nome: ");
        nome = Console.ReadLine().ToUpper();
        
        //instanciar um objeto pessoa
        Pessoa pessoa = new Pessoa(nome, email);

        //adicionar na lista
        if (lista.Contains(pessoa)) {
            Console.WriteLine("Email já em uso!");
        } else {
            lista.Add(pessoa);
            lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));
            Persistencia.gravarSimples(pessoa,"amigos.csv");
        }
    }

    public static void listarPessoas(List<Pessoa> lista)
    {
        foreach (var pessoa in lista)
        {
            Console.WriteLine(pessoa);
        }
    }

    public static void gerarAmigoSecreto(List<Pessoa> lista) {
        List<Pessoa> listaTmp = new List<Pessoa>();
        listaTmp.AddRange(lista);

        bool deuCerto;
        do {
            deuCerto = true;
            listaTmp = listaTmp.OrderBy(x=> Random.Shared.Next()).ToList();

            for (int i = 0; i < lista.Count; i++) {
                if (lista[i] == listaTmp[i]) {
                    deuCerto = false;
                    listaTmp.Clear();
                    listaTmp.AddRange(lista);
                    break;
                }
            }
        } while (!deuCerto);

        Persistencia.gerarArquivoAmigoSecreto(lista, listaTmp);
        //gustavo;gus@ufn.edu.br;alex;alexz@ufn.edu.br

    }
}
