
namespace EstudosPoo.Models
{
    public class Aluno : Pessoa
    {

        //construto e obrigado passa nome
        public Aluno(string _nome) : base(_nome)
        {

        }


        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, Sou {Nome.ToUpper()}, de {Idade} Anos, Sou Aluno nota {Nota}");
        }

    }
}