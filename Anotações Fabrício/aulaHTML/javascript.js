

var n1 = 10;
var n2 = 10.5;
var n3 = 1.5e3;
var n4 = 0xff;

var s1 = "teste";
var s2 = 'teste';

var b1 = true;

var u = undefined;
var n = null;

var obj = 
{
   id: 30,
   nome: "Fabrício"
}

var array = ["string1", "string2", "string3", "string4", "string5"];

var funcao = function (x, y) {  return x + y; };

var numero = 1;

if(numero == "1")
{
    //alert("com == entrou aqui? SIM");
}

if(numero === "1")
{
    //alert("com === entrou aqui? Não");
}

var x = (numero === "1") ? "Nunca executa!" : "Numero é diferente de string, mesmo com o valor igual, ele da falso!";
//alert(x);


// var laranjas = 6;

// switch (laranjas) 
// {
//     case 3:
//         alert("Faz um copo de suco");
//         break;
//     case 6:
//         alert("Faz dois copos de suco");
//         break;
//     case 9:
//         alert("Faz três copo de suco");
//         break;
//     default:
//         alert("Faz uma jarra de suco ou mais");
//         break;
// }


// var pessoas = ["Alexandre", "Lucas", "Rodrigo", "Isaque"];

// for(var i=0; i<pessoas.length; i++)
// {
//     alert(pessoas[i]);
// }


// var nome = "";

// var pessoa = {nome:'Fabrício', sobrenome:'Londero'};

// for(x in pessoa)
// {
//     nome += pessoa[x] + " ";
// }

// alert(nome);

// var resultado = "";
// var numero = 1;

// while(numero <=10)
// {
//     resultado += numero + " ";
//     numero++;
// }

// alert(resultado);


//  var resultado = "";
//  var numero = 1;

// do
// {
//     resultado += numero + " ";
//     numero++;
// } while(numero <= 10);

// alert(resultado);

// var mensagem = "Obrigado novamente!";

function minhaFuncao()
{
    alert(mensagem);
}

 
/*var teste = "valor1";
var vezes = 4;

if(vezes > 3)
{
    var teste = "teste";
    alert(teste);
}

alert(teste);*/

// let teste = "valor1";
// let vezes = 4;

// if(vezes > 3)
// {
//     let j = "teste";
//     alert(j);
// }

// alert(teste);
// alert(j);


// var tags = document.getElementsByTagName("p");
// alert(tags);

// var elementos = document.querySelectorAll(".minhaClasse");
// alert(elementos);   

// var classes = document.getElementsByClassName("minhaClasse");
// alert(classes);


// var elemento = document.getElementById("paragrafo2");
// alert(elemento);

function alterarParagrafo()
{
    var paragrafo = document.getElementById("paragrafo2");
    paragrafo.innerHTML = paragrafo.innerHTML.toUpperCase();
}

function mostrarConteudo()
{
    var campo = document.getElementById("nome");
    alert(campo.value);
}