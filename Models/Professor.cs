using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{

    public class Professor : Pessoa
    {
        //construtor do professor
         public  Professor(string nome, int idade, decimal salario) {
            Nome = nome;
            Idade = idade;
            Salario = salario;

          }




        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            //base.Apresentar();
            Console.WriteLine($"Ola, Meu nome é {Nome}, Tenho {Idade} Anos, Ganho R$ {Salario}");
        }
    }
}