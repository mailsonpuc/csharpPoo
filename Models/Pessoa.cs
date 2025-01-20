
namespace EstudosPoo.Models
{
    public class Pessoa
    {
        public Pessoa(string _nome)
        {
            Nome = _nome;
        }

        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }


        public virtual void Apresentar()
        {
            Console.WriteLine($"Ola, Meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}