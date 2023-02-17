using System;
using System.Globalization;

namespace TerceiraAtvd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu Número de Identificação");
            int NumFunc = int.Parse(Console.ReadLine());

            Console.WriteLine("Por quantas horas você trabalhou?");
            double HorasTrab = double.Parse(Console.ReadLine());

            Console.WriteLine("O Quanto você recebe por hora trabalhada?");
            double ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = HorasTrab * ValorHora;

            Console.WriteLine("Number: " + NumFunc);
            Console.WriteLine("Salary: " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}