
namespace csharpPoo.Models.ex002
{
    public class Calculadora
    {
        public Calculadora(int _n1, int _n2)
        {
            N1 = _n1;
            N2 = _n2;
        }


        public int N1 { get; set; }
        public int N2 { get; set; }

        public virtual void Resultado()
        {

        }
    }
}