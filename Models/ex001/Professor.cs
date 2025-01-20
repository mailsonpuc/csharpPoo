
using System.Globalization;

namespace csharpPoo.Models.ex001
{
    public class Professor : Pessoa
    {
        //passando o nome do professor para class pai Pessoa
        public Professor(string _nome) : base(_nome)
        {

        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            CultureInfo real = new CultureInfo("pt-BR");
            Console.WriteLine($"Olá, Meu nome é {Nome}, de {Idade} anos, e sou professor e ganho {Salario.ToString("C", real)} salario");
        }
    }
}