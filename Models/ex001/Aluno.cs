
namespace csharpPoo.Models.ex001
{
    public class Aluno : Pessoa
    {
        //base(), passando o _nome de aluno para class pai Pessoa
        public Aluno(string _nome, double _nota, int _idade) : base(_nome)
        {
            Nota = _nota;
            Idade = _idade;
        }


        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola, eu nome é {Nome} e sou Aluno Nota {Nota}");
        }
    }
}