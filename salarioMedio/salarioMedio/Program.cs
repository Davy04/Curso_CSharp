
using salarioMedio;
using System.Net.Http.Headers;

Funcionario func1 = new Funcionario();
Funcionario func2 = new Funcionario();

double mediaSal;

Console.Write("digite o Nome do primeiro Funcionario: ");
func1.Nome = Console.ReadLine();

Console.Write("digite o salário do primeiro Funcionario: ");
func1.Salario = double.Parse(Console.ReadLine());

Console.Write("digite o Nome do segundo Funcionario: ");
func2.Nome = Console.ReadLine();

Console.Write("digite o salário do segundo Funcionario: ");
func2.Salario = double.Parse(Console.ReadLine());

mediaSal = (func1.Salario + func2.Salario) / 2;
Console.WriteLine("A media de salário foi : " + mediaSal);
