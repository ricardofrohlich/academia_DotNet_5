namespace AulaFuncoes
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            double a, b;
            string retorno;
            Console.WriteLine("Digite dois números: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            soma(a, b);
            multiplicar(a, b);
            //retorno = verificaPar(5);
            //Console.WriteLine("O retorno da função verificaPar = "+retorno);
            Console.WriteLine("O retorno da função verificaPar = "+verificaPar(5));

            retorno = verificaPar(a);
            Console.WriteLine("O retorno da função verificaPar = " + retorno);
            retorno = verificaPar(b);
            Console.WriteLine("O retorno da função verificaPar = " + retorno);

            //bool retornoV2;

            //retornoV2 = verificaParV2(a);
            if(verificaParV2(a))//if(retornoV2)//if (retornoV2 == true)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            //Console.WriteLine("O retorno da função V2 = "+retornoV2);

            string mensagem = "O número é ";
            mensagem += verificaParV2(a) ? "Par" : "Ímpar";
            Console.WriteLine(mensagem);

        }

        private static bool verificaParV2(double a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }

        static string verificaPar(double v)
        {
            if(v%2==0)
            {
                //Console.WriteLine("Par!");
                return "Par";
            }
            else
            {
                //Console.WriteLine("Impar!");
                return "Impar";
            }
        }

        static void multiplicar(double a, double b)
        {
            double resultado;
            resultado = a * b;
            Console.WriteLine("O resultado da multiplicação é igual a " + resultado);
        }

        static void soma(double a, double b)
        {
            double resultado;
            resultado = a + b;
            Console.WriteLine("O resultado da soma é igual a " + resultado);
        }

        /*Agora, vamos fazer duas funções:
Uma função para fazer a leitura de dois números 
Outra para somar dois números*/



        static void apresentaMensagem()
        {
            Console.WriteLine("Eu estou aqui na função!");
        }


    }
}