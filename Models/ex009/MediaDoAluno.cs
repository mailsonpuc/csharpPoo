

namespace csharpPoo.Models.ex009
{
    public class MediaDoAluno
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        public void CalcularNota()
        {
            var media = (Nota1 + Nota2) / 2;
            var m = (media <= 5) ? "Nota RUIM" : "Nota BOA";

            Console.WriteLine($"A Média entre {Nota1} e {Nota2} é igual a {media}: Sua nota Foi -> {m}");
        }
    }
}