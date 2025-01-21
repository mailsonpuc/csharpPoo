
namespace csharpPoo.Models.ex004
{
    /*abstract server apenas como modelo para ser herdado,
    não pode se extanciado.
    */

    public abstract class Conta
    {
        /*protegico contra alteraçoẽs externar
        Apenas as class filhas pode altera protected
        */
        protected decimal Saldo;

        /*quem herdar da class conta, tem que
        obrigatoriamente implementa Creditar*/
        public abstract void Creditar(decimal valor);

        //implementação
        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu Saldo é {Saldo}");
        }
    }
}