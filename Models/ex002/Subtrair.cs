
namespace csharpPoo.Models.ex002
{
    public class Subtrair : Calculadora
    {
        public Subtrair(int _n1, int _n2) : base(_n1, _n2)
        {

        }

        public override void Resultado()
        {
            Console.WriteLine($"A subtração entre {N1} e {N2} é {N1 - N2}");
        }
    }
}