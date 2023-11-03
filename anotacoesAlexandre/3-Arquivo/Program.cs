using _4_Arquivo;
Console.Clear();

string nome, email;
List<Pessoa> lista = new List<Pessoa>();
Persistencia.popularArquivoLista("alunos.csv", lista); //conexao com a base

Persistencia.exibirLista(lista);

Pessoa tmp;
do {
    Console.Write("Digite nome ou sair para finalizar: ");
    nome = Console.ReadLine().ToUpper();
    if (nome == "SAIR"){
        break;
    }
    Console.Write("Digite email: ");
    email = Console.ReadLine().ToLower();
    tmp = new Pessoa(nome, email);

    if (lista.Contains(tmp)) {
        Console.WriteLine("Email já em uso!!");
    } else {
        lista.Add(tmp);
        Persistencia.gravarSimples(tmp,"alunos.csv");
    }
} while(true);
































// List<Pessoa> listaPessoas = new List<Pessoa>();

// Persistencia.popularArquivoLista("dados.dat", listaPessoas);

// string nome;
// string dataNascimento;
// Pessoa pessoa;
// // for (int i = 0; i < 3; i++)
// // {
// //     Console.Write("Nome: ");
// //     nome = Console.ReadLine();

// //     Console.Write("Data Nascimento: ");
// //     dataNascimento = Console.ReadLine();

// //     pessoa = new Pessoa(nome, dataNascimento);

// //     if (!listaPessoas.Contains(pessoa)) //????
// //     {
// //         listaPessoas.Add( pessoa );
// //         Persistencia.atualizarPessoaArquivo(pessoa, "dados.dat");
// //     } else
// //     {
// //         Console.WriteLine("Pessoa com este email já na base de dados");
// //     }
// // }

// Persistencia.exibirLista(listaPessoas);

// Console.Write("Digite nome a ser excluido: ");
// nome = Console.ReadLine();

// bool removeu = false;
// foreach (var item in listaPessoas)
// {
//     if (nome == item.Nome) {
//         listaPessoas.Remove(item);
//         removeu = true;
//         break;
//     }
// }
// if (removeu) {
//     Persistencia.gravarListaArquivo(listaPessoas, "dados.dat");
// }



// //Persistir na base de dados
// //Persistencia.gravarListaArquivo(listaPessoas, "C:\\Users\\alexz\\academia_AtosUFN_DotNet_4\\anotacoesAlexandre\\dados.dat");