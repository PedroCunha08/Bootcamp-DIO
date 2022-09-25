using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Iremos realizar a tabuada do 5 utilizando o comando de repetição for
        int numero = 5;
//oberve que o comando for requer a declaração de 3 prametros
//   (1ºParametro)  (2ºParametro) (3ºParametro)
for (int cont = 0;  cont <= 10; cont++)
{ 
     Console.WriteLine($"{numero} x {cont} = {numero * cont}");

}

int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;

}

//CRIANDO UMA FUNÇÃO SOMA DE VALORES ATÉ SER INTERROMPIDO E DEVOLVENDO RESULTADO
// condição do While - a maior diferença é a execução do codigo antes de verificar a condição

int soma = 0, number = 0; //Oberve que declaramos as variaveis com o valor 0

do  //Neste comando, primeiramente será executado o codigo
{
    Console.WriteLine("Digite um numero positivo ou 0 para parar");
    number = Convert.ToInt32(Console.ReadLine());

    soma += number; //neste caso, o sima += é o mesmo que descrever soma = soma + numero

} while (number != 0); //Neste caso o sinal combinado != signifa diferente
                       //Lembra-se que executamos o codigo primeiro?
                       //Se houvessemos usado o for ou While o comando pararia, pois ele para quando
                       // o numero for = 0
                       //por isso utilizamos a comando Do Whie, para que primeiro execute o codigo 
                       //e depois a verifique a condição

Console.WriteLine($"Total da soma dos numero digitados é: {soma}");


