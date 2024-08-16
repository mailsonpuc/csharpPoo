using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        //Este metodo pode ser subscrito
        public virtual void Apresentar(){
            Console.WriteLine($"Ola, Meu nome é: {Nome} idade: {Idade}");
        }
    }
}