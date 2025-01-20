
namespace csharpPoo.Models.ex003
{
    public class CalculadoraCientifica : ICalculadora
    {
        public int N1 { get; set; }
        public int N2 { get; set; }


        public int Dobro(int N1)
        {
            return N1 * 2;
        }


        public int Triplo(int N1)
        {
            return N1 * 3;
        }


        public double Raiz(int N1)
        {
            return Math.Sqrt(N1);
        }

        public int Dividir(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Multiplicar(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Soma(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }
}