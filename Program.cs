
using System.Collections.ObjectModel;
using csharpPoo.Models.ex001;
using csharpPoo.Models.ex002;
using csharpPoo.Models.ex003;

Console.Clear();


Console.WriteLine("-".PadLeft(80, '-'));

ICalculadora calc = new CalculadoraNormal();
Console.WriteLine(calc.Soma(5, 5));
Console.WriteLine(calc.Subtrair(15, 5));
Console.WriteLine(calc.Multiplicar(5, 5));
Console.WriteLine(calc.Dividir(50, 5));


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