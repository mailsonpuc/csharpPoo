
namespace csharpPoo.Models.ex002
{
    public class Soma : Calculadora
    {
        public Soma(int _n1, int _n2) : base(_n1, _n2)
        {

        }


        public override void Resultado()
        {
            Console.WriteLine($"A soma entre {N1} e {N2} é {N1 + N2}");
        }
    }
}