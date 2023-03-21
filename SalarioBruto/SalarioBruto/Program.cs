using System;
using System.Globalization;

namespace SalarioBruto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Digite o nome do Funcionario: ");
            f.Nome = Console.ReadLine();

            Console.Write("Digite o salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Digite o imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario " + f);

            Console.WriteLine();
            Console.Write("digite a porcentagem para aumentar o salário: " );
            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}