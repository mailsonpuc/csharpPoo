

namespace csharpPoo.Models.ex010
{
    public class MaiorEmenorValor
    {
        public MaiorEmenorValor()
        {
            num = new List<int>();
        }

        public List<int> num { get; set; }

        public void CalcularResultado()
        {

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("os Números passado FOI....\n");
            Console.ResetColor();
            Thread.Sleep(3000);


            int soma = 0;
            foreach (var item in num)
            {
                Console.WriteLine(item);
                soma += item;
            }

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Analizando os Números passado....\n");
            Console.ResetColor();
            Thread.Sleep(2000);

            Console.WriteLine($"O maior Número foi {num.Max()}, E o menor {num.Min()}");
            Console.WriteLine($"A soma de todos os Números é {soma}");

            double media = (double)soma / 2;
            Console.WriteLine($"A média é {media}");
        }




    }
}