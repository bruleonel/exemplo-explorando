using ExemploExplorando.Models;

/*Pessoa p1 = new Pessoa();
p1.Nome = "Bruna";
p1.Sobrenome = "Leonel";
p1.Idade = 20;
p1.Apresentar();*/

//Modo sem construtor
Pessoa p1 = new Pessoa();
p1.Nome = "Bruna";
p1.Sobrenome = "Leonel";

//Modo com construtor
Pessoa p = new Pessoa("Cristiane", "Leonel");

Pessoa p2 = new Pessoa();
p2.Nome = "Julia";
p2.Sobrenome = "Leonel";

Pessoa p3 = new Pessoa();
p3.Nome = "Giulianno";
p3.Sobrenome = "Leonel";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.AdicionarAluno(p);
cursoDeIngles.ListarAluno();