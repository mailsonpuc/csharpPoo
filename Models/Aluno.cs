using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Aluno : Pessoa
    {
      public double Nota { get; set; }

        public override void Apresentar()
        {
            //base.Apresentar();
            Console.WriteLine($"Ola, Meu nome é {Nome}, Tenho {Idade} anos, Sou Aluno Nota {Nota}");
        }
    }
}