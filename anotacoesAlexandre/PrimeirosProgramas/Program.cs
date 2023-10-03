//1) Escreva um programa em C# e no Visual Studio para calcular a média
//aritmética entre dois números quaisquer.

//int valor1;
//int valor2;
//float media;

//Console.Write("Digite um valor inteiro: ");
//valor1 = int.Parse(  Console.ReadLine() );
//Console.Write("Digite um outro valor inteiro: ");
//valor2 = int.Parse(Console.ReadLine());

//media = (valor1 + valor2) / 2;

//Console.WriteLine("A média dos valores é: " + media);

//3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio,
//para trocar entre si os valores de duas variáveis A e B.

//int a = 9;
//int b = 10;

//a <= 10
//b <= 9
//tmp <= a <= 9
//a <= b <= 10
//b <= tmp

//int tmp = a; //backup do conteudo do a
//a = b; //a recebe o conteudo do b
//b = tmp; //o conteudo salvo em tmp vai para b

//Console.Write("Digite uma frase qualquer: ");
//string frase = Console.ReadLine();

//Console.WriteLine("Você digitou....: " + frase.ToUpper());
//Console.WriteLine("Esta frase tem " + frase.Length + " caracteres");


//Console.Write("Digite algo para pesquisar: ");
//string palavra = Console.ReadLine();    

//if (frase.Contains(palavra))
//{
//    Console.WriteLine(palavra + " aparece na frase");
//    //bloco de instruções caso a palavra esteja na frase
//} else
//{
//    Console.WriteLine(palavra + " não aparece na frase");
//    //bloco de instruções caso a palavra não esteja na frase
//}

//4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA 
//e imprima na forma AAAAMMDD e AAMMDD. 
//Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.


//Console.Write("Digite uma data [dd/mm/aaaa]: ");
//string data = Console.ReadLine();
//string []vetorData = data.Split('/');

//Console.WriteLine(vetorData[2] + "/" + vetorData[1] + "/" + vetorData[0]);

//string ano = vetorData[2];
//Console.WriteLine(ano.Substring(2) + "/" + vetorData[1] + "/" + vetorData[0]);

//data = '03/10/2023'
//vetorData [03, 10, 2023]
//vetorData[0] => 03
//vetorData[1] => 10
//vetorData[2] => 2023

//todo vetor é uma estrutura homogenea de n posições, sempre começando em 0


//DateOnly data = DateOnly.Parse("03/12/2023");
//Console.WriteLine(data.Year.ToString().Substring(2));
//Console.WriteLine(data.Month.ToString("D2"));
//Console.WriteLine(data.Day.ToString("D2"));


//if (condicao)
//{   //caso verdade
//    //bloco de instruções
//} else
//{   //caso falso
//    //bloco de instruções
//}

//if (condicao)
//{
//    //caso verdade
//    //bloco de instruções
//} else if (outracondicao)
//{   //caso seja falsa a primeira condição e verdadeira a segunda condição

//}

//1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores
//da base e da altura lidos pelo teclado: 
//Área do triangulo = (base * altura) / 2;
//Teste se a base ou a altura digitada não foi igual a zero. 

//Console.Write("Entre com um valor inteiro para a base do triangulo: ");
//int baseTriangulo = int.Parse(Console.ReadLine());


//Console.Write("Entre com um valor inteiro para a altura do triangulo: ");
//int alturaTriangulo = int.Parse(Console.ReadLine());

//if (baseTriangulo != 0 && alturaTriangulo != 0)
//{
//    float areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
//} else
//{
//    Console.WriteLine("Um dos valores de base ou altura está igual 0!");
//}


//6 - Faça um programa em C# e no Visual Studio para receber o nome
//(totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
//O programa deve calcular o Indice de Massa Corpórea (IMC), exibi - lo ao usuário e
//informar sua situação conforme a tabela.
//O cálculo do imc = peso / (altura * altura)

//IMC
//menor que 18                -> baixo peso
//maior que 18 e menor que 25 -> peso normal
//maior que 25 e menor que 30 -> sobrepeso
//maior que 30 e menor que 35 -> obesidade
//maior que 35                -> obesidade grau sério

Console.Write("Informe seu nome: ");
string nome = Console.ReadLine().ToUpper();

Console.Write("Sua altura em metros: ");
double altura = double.Parse( Console.ReadLine() );

Console.Write("Seu pso em kilos: ");
double peso = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);
Console.WriteLine(nome + " seu IMC é de " + imc.ToString("0.#"));

if (imc < 18)
{
    Console.WriteLine("Baixo peso");
} else if (imc < 25)
{
    Console.WriteLine("Peso normal");
} else if (imc < 30)
{
    Console.WriteLine("Sobre peso");
}
else if (imc < 35)
{
    Console.WriteLine("Obesidade");
} else
{
    Console.WriteLine("Obesidade grau sério");
}