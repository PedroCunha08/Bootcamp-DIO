using C_Aula09.Models;

Pessoa p1 = new Pessoa("Pedro", "Cunha", 48);

Pessoa p2 = new Pessoa("Marcos", "Pontes", 50);

//Pessoa p1 = new Pessoa(); //Aqui estamos instanciando a classe pessoa da pasta models (public class Pessoa)
// p1.Nome     = "Pedro";
// p1.LastName = "Cunha";
// p1.Idade    = 48;

// Pessoa p2   = new Pessoa();
// p2.Nome     = "Marcos";
// p2.LastName = "Pontes";
// p2.Idade    =  50

Curso cursoDeIngles = new Curso();
cursoDeIngles.nomeCurso = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

//p1.Idade = 48;
//p1.Apresentar(); Neste comando estamos solicitando a apresentação do conteudo das variaveis listadas acima
