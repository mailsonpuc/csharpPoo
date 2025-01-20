
namespace EstudosPoo.Models
{
    public class Professor : Pessoa
    {

        //base() passando o _nome para class pai, Pessoa
        public Professor(string _nome) : base(_nome)
        {

        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá sou Professor {Nome.ToUpper()}, de {Idade} anos, Ganho {Salario} salario");
        }
    }
}