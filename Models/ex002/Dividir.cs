
namespace csharpPoo.Models.ex002
{
    public class Dividir : Calculadora
    {
        public Dividir(int _n1, int _n2) : base(_n1, _n2)
        {

        }

        public override void Resultado()
        {
            Console.WriteLine($"A divisão entre {N1} e {N2} È {N1 / N2}");
        }
    }
}