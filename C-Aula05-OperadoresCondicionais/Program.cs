using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


int Estoque = 100;

int venda = 0;

bool viabilidade = venda > 0 &&  Estoque >= venda;
Console.WriteLine($"É possivel realizar a sua venda? {viabilidade}");

if (venda == 0)
{
    Console.WriteLine("Valor informado deve ser igual ou maior que uma unidade");
}
else if (viabilidade)
{
        Console.WriteLine($"Venda realizada com sucesso! a quantidade vendida foi {venda} undiades. Obrigado");
}
else
{
        Console.WriteLine($"Desculpe-nos, não temos {venda} unidades em nossos estoques. Caso queira, ainda temos disponiveis {Estoque} unidades.");
}

//Estudando a utilização da condição "OU = Or" que é escrita com o simbolo "|| = Pipe"
//imagine que você tenha a condição para entrada em um bar que tenha de ser maior de 18 anos ou tenha autorização

bool maiorIdade = false;
bool autorizacao = false;

if (maiorIdade || autorizacao) // se for maior de idade ou tenha autorização
{
    Console.WriteLine("Entrda permitida");
}
else
{
    Console.WriteLine("Entrada Não Permitida");
}

//É possivel ainda se deparar com a necessidade de duas condições serem verdadeiras
//imagine que você preciso validar a condição de aprovação de uma aluno que tenha presença minima e nota maior que 7



bool presenca = true;
bool media = true;

if (presenca && media)
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Alno Reprovado");
}


// Outra que pode se apresentar é a necessidade de se realizar diveras vezes o if else
//Imagine que você precise identificar se o valor digitado é uma vogal ou não. Veja como pode ser feito

Console.WriteLine("digite uma letra!");
string letra = Console.ReadLine();

if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")

{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Não é uma vogal");
}

//Porem como para casos similares ao apresentado acima, existe o comando mais recomendado
//chamdo switch, e funciona da forma abaixo descrita
Console.WriteLine("digite uma letra!");
string vogal = Console.ReadLine();

switch (vogal)
{
    case ("a"):
    case ("e"):
    case ("i"):
    case ("o"):
    case ("u"):
        Console.WriteLine("A Letra informada é uma vogal");
        break;
    default:
        Console.WriteLine("A letra informada não é uma vogal;");
        break;
}


//Outra forma de utiilizar o switch, seria atribuir uma condição para cada caso(case), como no exemplo abaixo
//Console.WriteLine("digite uma letra!");
// string vogal = Console.ReadLine();

// switch (vogal)
// {
//     case ("a"):
//         Console.WriteLine("A Letra 'A' é uma vogal");
//         break;
//     case ("e"):
//         Console.WriteLine("A Letra 'E' é uma vogal");
//         break;
//     case ("i"):
//         Console.WriteLine("A Letra 'I' é uma vogal");
//         break;
//     case ("o"):
//         Console.WriteLine("A Letra 'O' é uma vogal");
//         break;
//     case ("u"):
//         Console.WriteLine("A Letra 'U' é uma vogal");
//         break;
//     default:
//         Console.WriteLine("A letra informada não é uma vogal;");
//         break;
// }