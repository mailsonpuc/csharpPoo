using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Aluno : Pessoa
    {
     //construtor do aluno 
      public Aluno (string nome, int idade, double nota){
        Nome = nome;
        Idade = idade;
        Nota = nota;

      }




      public double Nota { get; set; }

        public override void Apresentar()
        {
            //base.Apresentar();
            Console.WriteLine($"Ola, Meu nome é {Nome}, Tenho {Idade} anos, Sou Aluno Nota {Nota}");
        }
    }
}