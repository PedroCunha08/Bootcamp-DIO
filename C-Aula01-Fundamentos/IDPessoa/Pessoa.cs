using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01.fundamentos.IDPessoa
{
    public class Pessoa
    {
       public string Nome { get; set; }
       public int Idade { get; set; }

       public void Apresentar()
       {
            //Caso seja necessário mudar de linha no código por ter ficado muito estenso, 
            // basta fechar as aspas duplas e colocar o sinal de + e na linha seguinte iniciar por $
            // Console.WriteLine($"Olá, meu nome é  {Nome}" +
            // $"e tenho {Idade}");
            Console.WriteLine($"Olá, meu nome é  {Nome}\n e tenho {Idade}");
        }

       
    }
}