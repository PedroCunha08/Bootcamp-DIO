using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Aula09.Models
{
    public class Curso
    {
        public string nomeCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }  //Oberve que dentro da lista é indicado o tipo Pessoa. Isto quer dizer que o tipo de dados deverá respeitar todos os criterios que definimos na Classe pessoa do Arquivo Pessoa

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int quantidadeAlunosCadastrados()
        {
            int QuantidadeAlunos = Alunos.Count;
            return QuantidadeAlunos;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
           return Alunos.Remove(aluno);
        }

        public void ListarAlunos() 
        {
            Console.WriteLine($"Alunos do curso de {nomeCurso}");
            for (int contador = 0; contador < Alunos.Count; contador++)
            {
                //string texto = "Nº" + contador + " - " + Alunos[contador].CompletName; // CONCATENAÇÃO
                string texto = $"Nº {contador + 1} - {Alunos[contador].CompletName}"; //INTERPOLAÇÃO DE STRING
                Console.WriteLine(texto);
            }

        }
        

    }
}