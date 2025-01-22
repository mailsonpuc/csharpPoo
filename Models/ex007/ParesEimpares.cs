
namespace csharpPoo.Models.ex007
{
    public class ParesEimpares
    {
        //construtor
        public ParesEimpares()
        {
            Numeros = new List<int>();
        }


        public List<int>? Numeros { get; set; }

        public virtual void ExibirImformacao()
        {
            foreach (var item in Numeros)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"PAR: {item}");
                }

                else if (item % 2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"IMPAR: {item}");
                    Console.ResetColor();
                }

            }
        }
    }
}