
using System.Collections.ObjectModel;
using csharpPoo.Models.ex001;
using csharpPoo.Models.ex002;
using csharpPoo.Models.ex003;
using csharpPoo.Models.ex004;
using csharpPoo.Models.ex005;
using csharpPoo.Models.ex006;
using csharpPoo.Models.ex007;
using csharpPoo.Models.ex008;
using csharpPoo.Models.ex009;

Console.Clear();


Console.WriteLine("-".PadLeft(100, '-'));



MediaDoAluno ruam = new MediaDoAluno();
ruam.Nota1 = 5.5;
ruam.Nota2 = 9;
ruam.CalcularNota();







// SorteandoPessoaNaList pNaList = new SorteandoPessoaNaList();

// pNaList.Pessoas.Add("Maui");
// pNaList.Pessoas.Add("Zuru");
// pNaList.Pessoas.Add("Maik");

// pNaList.ExibirInformacao();




// ParesEimpares pp = new ParesEimpares();

// pp.Numeros.Add(5);
// pp.Numeros.Add(new Random().Next(1, 100));
// pp.Numeros.Add(new Random().Next(1, 100));
// pp.Numeros.Add(new Random().Next(1, 100));
// pp.Numeros.Add(new Random().Next(1, 100));
// pp.Numeros.Add(new Random().Next(1, 100));
// pp.Numeros.Add(new Random().Next(1, 100));
// pp.ExibirImformacao();








// PessoaNormal maria = new PessoaNormal();
// maria.Nome = "Maria";
// maria.Idade = 33;
// maria.Empregos.Add("Densevolvedora Front-end");
// maria.Empregos.Add("Designer");
// maria.Empregos.Add("Video de Youtube");
// maria.Empregos.Add("Palestrante");

// maria.ExibirInformacao();

// foreach (var item in maria.Empregos)
// {
//     Console.WriteLine(item);
// }












// PessoaFisica maria = new PessoaFisica();
// Guid chaveAleatoria = Guid.NewGuid();
// string MinhaChavePix = chaveAleatoria.ToString();

// maria.Chave = MinhaChavePix;
// maria.Nome = "Maria smith";
// maria.Saldo = 100;
// maria.ExibirSaldo();

// maria.Receber(20);
// maria.ExibirSaldo();

// maria.Enviar(50);
// maria.ExibirSaldo();

Console.WriteLine("-".PadLeft(100, '-'));





/*extanciando a class abstrata conta
Não é possível criar uma instância do tipo abstrato 
-> Conta conta1 = new Conta();
*/
// Corrente c1 = new Corrente();
// c1.Creditar(500);
// c1.ExibirSaldo();
//-> c1.Saldo(); Não aparece ,porque é protegido








// ICalculadora calc = new CalculadoraNormal();
// Console.WriteLine($"A soma 5 + 5 = {calc.Soma(5, 5)}");
// Console.WriteLine($"A subtração 15 - 5 = {calc.Subtrair(15, 5)}");
// Console.WriteLine($"A multiplicação 5 X 5 = {calc.Multiplicar(5, 5)}");
// Console.WriteLine($"A Divisão 50 / 5 = {calc.Dividir(50, 5)}");


// CalculadoraCientifica calcCientifica = new CalculadoraCientifica();
// calcCientifica.N1 = 5;
// Console.WriteLine($"Soma de 5 + 5 = {calcCientifica.Soma(5, 5)}");

// Console.WriteLine($"Tripo de 5 é {calcCientifica.Triplo(5)}");
// Console.WriteLine($"A raiz de 5 é {calcCientifica.Raiz(5)}");

// Aluno al1 = new Aluno("Mailson", 10, 28);
// al1.Apresentar();


// Console.WriteLine("-".PadLeft(80, '-'));
// Professor prf1 = new Professor("Pedro");
// prf1.Idade = 50;
// prf1.Salario = 5600;
// prf1.Apresentar();
// Console.WriteLine("-".PadLeft(80, '-'));


// Console.WriteLine("-".PadLeft(80, '-'));

// Soma sm1 = new Soma(5, 5);
// sm1.Resultado();

// Subtrair sub1 = new Subtrair(10, 5);
// sub1.Resultado();

// Multiplicar mult1 = new Multiplicar(5, 5);
// mult1.Resultado();

// Dividir divi1 = new Dividir(100, 2);
// divi1.Resultado();

// Console.WriteLine("-".PadLeft(80, '-'));