
namespace csharpPoo.Models.ex004
{
    public class Corrente : Conta
    {
        //implementando o metodo Creditar Abstrado de conta
        public override void Creditar(decimal valor)
        {
            Saldo += valor;
        }
    }
}