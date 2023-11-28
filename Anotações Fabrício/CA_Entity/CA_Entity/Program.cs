using CA_Entity.DataModels;
using Microsoft.EntityFrameworkCore;

namespace CA_Entity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite:\n" +
                "1 para criar uma pessoa\n" +
                "2 para alterar o nome da pessoa\n" +
                "3 para inserir um email\n" +
                "4 para excluir a pessoa\n" +
                "5 para consultar tudo\n" +
                "6 para consultar pelo ID da pessoa\n");

            int op = int.Parse(Console.ReadLine());

            Contexto contexto = new Contexto();

            switch (op)
            {
                case 1:
                    try
                    {
                        Pessoa p = new Pessoa();
                        Console.WriteLine("Insira o nome da pessoa:");
                        p.nome = Console.ReadLine();

                        Console.WriteLine("Insra um email:");
                        string emailTemp = Console.ReadLine();

                        p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };

                        //Email e = new Email();
                        //e.email = emailTemp;

                        //p.Emails.Add(e);

                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();
                        Console.WriteLine("Pessoa isnerida com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa:");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa pAlt = contexto.Pessoas.Find(id);

                        Console.WriteLine("Informe o nome correto:");
                        pAlt.nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlt);
                        contexto.SaveChanges();

                        Console.WriteLine("Alteração efetuada!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Informar um novo email:");
                        string emailTemp = Console.ReadLine();

                        p.Emails.Add(new Email() { email = emailTemp });

                        //contexto.Pessoas.Update(p);
                        contexto.SaveChanges();
                        Console.WriteLine("Sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Confirma a exclusão de " + p.nome + "" +
                            "e de seus emails?");

                        foreach (Email e in p.Emails)
                        {
                            Console.WriteLine("\t" + e.email);
                        }

                        Console.WriteLine("1 para SIM e 2 para NÃO");
                        if(int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine(p.nome + " removido com sucesso!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    try
                    {
                        //LINQ
                        List<Pessoa> lista = 
                            (from Pessoa p in contexto.Pessoas select p)
                            .Include(pes => pes.Emails)
                            .ToList<Pessoa>();

                        foreach (Pessoa p in lista)
                        {
                            Console.WriteLine(p.nome);

                            foreach (Email e in p.Emails)
                            {
                                Console.WriteLine("\t" + e.email);
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 6:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa");
                        int id = int.Parse(Console.ReadLine());
                        
                        Pessoa pessoa = contexto.Pessoas.Include(p => p.Emails)
                                            .FirstOrDefault(p => p.id == id);

                        Console.WriteLine(pessoa.nome);

                        foreach (Email item in pessoa.Emails)
                        {
                            Console.WriteLine("\t" + item.email);
                        }


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

            }
        }
    }
}