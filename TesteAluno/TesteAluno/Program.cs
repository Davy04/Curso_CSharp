using System;
using System.Globalization;

namespace TesteAluno // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("digite as 3 notas do aluno: ");
            aluno.N1 = double.Parse(Console.ReadLine());
            aluno.N2 = double.Parse(Console.ReadLine());
            aluno.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }
        }
    }
}