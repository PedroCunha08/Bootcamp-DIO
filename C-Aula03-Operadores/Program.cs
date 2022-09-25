// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

int a = 10;
int b = 20;

int c = a + b;

Console.WriteLine(c);

//Tambem é possivel utilizar o resultado da sua variavel a um outro valor ou mesmo outra variavel

int d = 20;
int e = 30;

int f = d + e;

int z = c + f;

Console.WriteLine($"O valor de C é:  {c}");
Console.WriteLine($"O valor de F é:  {f}");
Console.WriteLine($"A soma das variaveis C + F é:  {z}");

/* Outra maneira de realizar calculos é utilizando uma mesma variavel já delcarada
para que seja atualizado o seu valor.
Imagine que o valor recebido pela variavel Z deva ser sempre acrescido de uma constante
de valor 10, independente do valor que resulte as comatorias anteriores. Para isto você 
irá realizar o calculo conforme o exemplo abaixo
*/

z += 50;
//Desta forma você está informando ao sistema que Some o valor informado 
//e Atualize o valor contido na variavel. Veja o resultado a seguir

Console.WriteLine($"O valor atualizado de Z e: {z}");

//Seguindo o mesmo principio, seria possivel eliminar a variavel Z, VEja

f += c + 50;
Console.WriteLine($"O valor Total da soma das variaveis é:  {f}");

