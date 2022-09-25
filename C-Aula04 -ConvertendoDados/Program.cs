using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Convertendo dados de entrada em dados uteis

int a = 5;

Console.WriteLine($"O valor da variavel A é: {a}");

//Agora imagine que você tenha recebido uma valor numerico de outra tabela e que 
//você o receba em formato "String" e precise garantir que seja apresentado em 
//formato interiro.
// int a = ("54698731"); //  neste caso será necessário realizar o tratamento do dado recebido

int b = int.Parse("54698731");
Console.WriteLine($"o valor da Variavel B é:  {b}");

//CAso o valor recebido seja fracionado, você terá de utilizar o tipo 
//String Valor = "54698.731";
decimal c = Convert.ToDecimal("54698.731");
Console.WriteLine($"o valor da Variavel C é:  {c}");

//Ja no caso de receber um valor aleatorio em que seja preciso converter para string,
//A forma mais pratica é a conversão direta através do toString. Veja como fica

string  misto = "1297895b";
Console.WriteLine($"O valor da variavel misto é: {misto}");

//Convertendo numeros inteiros para string

int numInteiro = 928437578;
string numInt = numInteiro.ToString();

Console.WriteLine($"O valor da variavel numInteiro é: {numInteiro}");

//Agora imagine um senario onde você tenha uma lista de valores a serem importados e validados
//para que a sua importção não seja interrompida ao encontrar uma inconsistencia, você precisará
//utilizar o tryparse. veja o exemplo abaixo
string a1 = "1234";
string a2 = "2345c";
string a3 = "3456";
string a4 = "4567";
int b1 = 0;
int b2 = 0;
int b3 = 0;
int b4 = 0;

//a sintaxe é inteiro.TenteReceber(valor de a1, se der certo insira na variavel b1,
// se não for possivel, retorne o valor existente em b1)
int.TryParse(a1, out b1);
int.TryParse(a2, out b2);
int.TryParse(a3, out b3);
int.TryParse(a4, out b4);
// o resultado será:
// Valor A1 importado: 1234
// Valor A2 importado: 0
// Valor A3 importado: 3456
// Valor A4 importado: 4567

Console.WriteLine($"Valor A1 importado: {b1}");
Console.WriteLine($"Valor A2 importado: {b2}");
Console.WriteLine($"Valor A3 importado: {b3}");
Console.WriteLine($"Valor A4 importado: {b4}");



