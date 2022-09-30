using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Aula09.Models
{
    public class Pessoa //o public quer dizer que esta classe será publica a todo o sistema
    {

        public Pessoa()
        {

        }

        public Pessoa(string nome, string lastName, int idade) //Os nomes contidos nos parentes, são novas referencias criadas das variaveis existentes
        {
            Nome     = nome;      //Onde Nome é o definido na propriedade
            LastName = lastName;
            Idade    = idade;
        }


        //Veja que agora iremos criar dois outros campos que serão usado para o encapsulamento das informações que serão recebidas
        private string _nome; //ao se criar um propriedade Private estamos cirando um encapsulamento que deverá recceber um tratamento
        private string _LastName;
        private int _idade; // O mesmo que o nome, estamis informando que estes campos receberão um tratamento;

        public string Nome //o public quer dizer que esta propriedade será publica a todo o sistema
        { // aqui estamos dizendo que o campo nome deverá receber o tratamento do campo _nome

            get => _nome.ToUpper(); //Esta forma de expressão é chamada "body expression"
            //Outra forma que poderá ser encontrado e o comando acima da forma completa
            // get  //a função get é para tratar os valores que serão recebidos - maiuscolo e minusculo,
            // {
            //     return _nome.ToUpper();
            // }
            set
            {

                //a função set é para configurar os requisitos de uma entrada de dados

                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }

        }

        public string LastName { get; set; }
        // {
        //     get => _LastName.ToUpper();

        // }
        public string CompletName => $"{Nome} {LastName}".ToUpper();
        public int Idade
        {
            get => _idade; //Observe que mesmo não sendo realizado tratamento, é necessário declara a origem do dado,

            set
            {
                if (value <=0)
                {
                    throw new ArgumentException("A idade deve ser maior que 1");
                }

                _idade = value;
            }
        }
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {CompletName}, Idade: {Idade}");

        }
    }
}