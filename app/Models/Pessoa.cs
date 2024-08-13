using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Pessoa
    {
        //construtor padrão
        public Pessoa(){

        }

        //construtor
        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            SobreNome = sobrenome;

        }
        private string _nome;
    

        
        public string Nome { 
            get => _nome.ToUpper();
       
            set
            {
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser Vazio");
                }

                _nome = value;
            }
            } 


            public string SobreNome { get; set; }
            public string NomeCompleto => $"{Nome} {SobreNome}";

        private int _idade;
        public int Idade { 
            get => _idade;

            set
            {
             if(value < 0){
                throw new ArgumentException("A idade não pode ser Menor que zero");
             }
             _idade = value;
            }
        }
     

        public void Apresentar(){
            Console.WriteLine($"Nome {NomeCompleto.ToUpperInvariant()}, Idade {Idade}");
        }
    }
}