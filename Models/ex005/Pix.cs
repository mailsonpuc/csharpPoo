
namespace csharpPoo.Models.ex005
{
    public abstract class Pix
    {
        public double Saldo;

        public string Chave { get; set; } = string.Empty;

        public abstract void Enviar(double valor);

        public abstract void Receber(double valor);


        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"Olá, seu Saldo é {Saldo}");
        }

    }
}