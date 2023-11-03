using _5_AmigoSecreto;

string opcao = "";
List<Pessoa> lista = new List<Pessoa>();

Persistencia.popularArquivoLista("amigos.csv", lista);


do
{
    Console.Clear();
    Console.WriteLine("Menu Amigo Secreto");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Gerar amigo secreto");
    Console.WriteLine("7 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Cadastro de amigo");
            Comunicacao.cadastrarPessoa(lista);
            //Persistencia.gravarListaArquivo(lista,"amigos.csv");
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Listagem de amigos");
            Comunicacao.listarPessoas(lista);

            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Geração do amgios secreto");
            Comunicacao.gerarAmigoSecreto(lista);
            break;
        case "7":
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.Write("Tecle ENTER para continuar.....");
    Console.ReadKey(true);
} while (opcao != "7");
