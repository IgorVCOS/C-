using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("igor", "Vale");

// p1.Nome = "Igor";
// p1.Sobrenome = "Vale";

Pessoa p2 = new Pessoa("Lontra", "Albu");
// p2.Nome = "lontra";
// p2.Sobrenome = "Albu"; 

Curso Ingles = new Curso();
Ingles.Nome = "Inglês";
Ingles.Alunos = new List<Pessoa>();

Ingles.AdicionarAluno(p1);
Ingles.AdicionarAluno(p2);
Ingles.ListarAlunos();