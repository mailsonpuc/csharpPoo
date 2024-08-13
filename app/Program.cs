using System.Collections.Generic;
using app.Models;


Pessoa p1 = new Pessoa(nome: "maria", sobrenome: "silva");


Pessoa p2 = new Pessoa(nome: "ana",sobrenome: "vasconcelo");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListaAlunos();

//p1.Idade = 22;
//p1.Apresentar();