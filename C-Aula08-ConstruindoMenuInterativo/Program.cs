using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Iremos construir um menu interativo

string opcao;
bool exibirMenu = true;

while (exibirMenu) 
{
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1 - Cadastrar Cliente:");
    Console.WriteLine("2 - Buscar Cliente:");
    Console.WriteLine("3 - Apagar Cliente:");
    Console.WriteLine("1 - Encerrar:");

    opcao = Console.ReadLine();

    switch(opcao) 
    {
        case "1":
            Console.Clear(); //Este comando irá limpar a tela e depois apresentar a opção 1
            Console.WriteLine("Cadastro de Cliente");
            break;

        case "2":
            Console.Clear();//Este comando irá limpar a tela e depois apresentar a opção 1
            Console.WriteLine("Busca de Cliente");
            break;
        
        case "3":
            Console.Clear(); //Este comando irá limpar a tela e depois apresentar a opção 1
            Console.WriteLine("Apagar Cliente");
            break;

        case "4":
            Console.Clear();  //Este comando irá limpar a tela e depois apresentar a opção 1
            Console.WriteLine("Encerrar");
            exibirMenu = false;

            //Environment.Exit(0); - Esta seria outra forma de construir uma opção de sir do menu
            break;

    }

}

Console.WriteLine("O programa Encerrou");
