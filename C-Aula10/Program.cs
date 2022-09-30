using System;
using System.Globalization;
using C_Aula10;

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivos("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine("Qauntidade linhas do arquivo:" + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);

    }
}
else
{
    Console.WriteLine("Não foi possivel realizar a leitura do arquivo");

}


int numero = 15;
bool ehPar = false;
ehPar = numero % 2 ==0;
Console.WriteLine($"O numero {numero} é " + (ehPar ? "Par" : "Impar"));









// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("BA"); //removendo item
// estados[SP] = "Sao Paulo"







// Stack<int> pilha = new Stack<int>();

// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// //exibindo a lista

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
// fila.Enqueue(10);

// //exibindo a lista

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(12);
// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }



// try
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }

//  catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
// }
//   catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Caminho do Diretorio não encontrado. {ex.Message}");
// }

//   catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma excessão genérica. {ex.Message}"); //O tratamento Excepition deve ser o ultimo, pois será o generico
// }

// finally
// {
//     Console.WriteLine("Este campo será executado sempre mesmo que existam erros antes!");

// }

