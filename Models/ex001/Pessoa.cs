
namespace csharpPoo.Models.ex001
{
    public class Pessoa
    {
        //construtor, obrigatorio Passa o Nome
        public Pessoa(string _nome)
        {
            Nome = _nome;
        }


        public string Nome { get; set; }
        public int Idade { get; set; }


        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, Meu Nome é {Nome} de {Idade} Anos");
        }
    }
}