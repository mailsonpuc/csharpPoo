using app.Models;


//aluno
Aluno aluno1 = new Aluno();

aluno1.Nome = "Mailson";
aluno1.Idade = 25;
aluno1.Nota = 10;
aluno1.Apresentar();


//professor
Professor professor1 = new Professor();
professor1.Nome = "Max";
professor1.Idade = 30;
professor1.Salario = 1500M;
professor1.Apresentar();
