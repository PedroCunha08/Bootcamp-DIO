// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

string apresentacao = "Olá, Seja bem vindo!";

int quantidade = 1;

double altura = 101.80;

decimal preco = 1.80M;

bool condicao = true;

DateTime dataAtual = DateTime.Now;

//O comando DateTime pode ser usado com varias condicionais parra acrescentar dias, meses e ano
// veja os exemplos a seguir

//DateTime dataAtual = DateTime.Now.AddDays(5); para somar 5 dias a data atual
//DateTime dataAtual = DateTime.Now.AddMonths(5); para adicionar 5 meses ao mes atual
//DateTime dataAtual = DateTime.Now.AddYears; para adcionar 5 anos a data atual
//Este recurso pode ser utilizado com outras várias variantes que podem ser utilizadas


DateTime dataFimContrato = DateTime.Now.AddMonths(48);
Console.WriteLine("A data de fim do contrato será:  " + dataFimContrato);

//Também é possivel ajustar a data para que seja apresentada conforme sua necessidade,
//Por exemplo, seja apresentada apenas a data sem o horario, para isso configure a data
//conforme exemplo a seguir - Note que a confiruação de exibição é inserida no console e não
//na declaração da variavel como acontece com as configurações
DateTime dataAbreviada = DateTime.Now;
Console.WriteLine("A data abreviada de hoje é:  " + dataAbreviada.ToString("dd/MM/yyyy"));


Console.WriteLine (apresentacao);
Console.WriteLine("O Valor da variavel quantidade é: " + quantidade);
Console.WriteLine("O valor da variavel altura é: " + altura.ToString("0.000"));
Console.WriteLine("O valor da variavel preço é: " + preco);
Console.WriteLine("O valor da variavel condição é: " + condicao);
Console.WriteLine("A data de hoje é:  " + dataAtual);
Console.WriteLine("A data de fim do contrato será:  " + dataFimContrato);



