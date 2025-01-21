
namespace csharpPoo.Models.ex005
{
    public class PessoaFisica : Pix
    {
        public string Nome { get; set; } = string.Empty;

        public override void Enviar(double valor)
        {
            Saldo -= valor;
        }

        public override void Receber(double valor)
        {
            Saldo += valor;
        }


        public override void ExibirSaldo()
        {
            Console.WriteLine($"Olá, {Nome}, Seu saldo é {Saldo}, Minha chave Pix é: {Chave}");
        }

    }
}