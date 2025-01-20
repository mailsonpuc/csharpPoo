
namespace csharpPoo.Models.ex001
{
    public class Aluno : Pessoa
    {
        //base(), passando o _nome de aluno para class pai Pessoa
        public Aluno(string _nome) : base(_nome)
        {

        }


        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola, eu nome é {Nome} e sou Aluno Nota {Nota}");
        }
    }
}