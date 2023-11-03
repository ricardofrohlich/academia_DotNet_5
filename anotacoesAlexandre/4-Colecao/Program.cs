using ColecaoCSharp;

List<Aluno> lista = new List<Aluno>();

lista.Add(new Aluno(45,"Alexandre"));
lista.Add(new Aluno(23, "Pedro"));
lista.Add(new Aluno(19, "Matheus"));
lista.Add(new Aluno(19, "Gabriel"));

Aluno aluno = new Aluno(45,"Alexandre");

if (lista.Contains(aluno)) {
    Console.WriteLine("Aluno já cadastrado ");
}

lista.Sort();

//lista.Sort((a, b) => a.Id.CompareTo(b.Id));
//lista = lista.OrderBy(x=> Random.Shared.Next()).ToList();

foreach (var item in lista)
{
    Console.WriteLine(item.Id + "  " + item.Nome);
}
