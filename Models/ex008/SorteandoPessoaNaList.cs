
namespace csharpPoo.Models.ex008
{
    public class SorteandoPessoaNaList
    {
        //construtor
        public SorteandoPessoaNaList()
        {
            Pessoas = new List<string>();
        }


        public List<string> Pessoas { get; set; }



        public void ExibirInformacao()
        {

            Random random = new Random();
            string escolhido = Pessoas[random.Next(Pessoas.Count)];

            Console.WriteLine($"A Pessoa Sorteada foi: {escolhido}");

        }
    }
}