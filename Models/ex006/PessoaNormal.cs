using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpPoo.Models.ex006
{
    public class PessoaNormal
    {
        //construtor
        public PessoaNormal()
        {
            //inializando a lista
            Empregos = new List<string>();
        }


        public string? Nome { get; set; }
        public int Idade { get; set; }

        public List<string>? Empregos { get; set; }

        public virtual void ExibirInformacao()
        {
            Console.WriteLine($"Ola, Meu Nome é {Nome}, de  {Idade} anos trebalho com.");
        }
    }
}