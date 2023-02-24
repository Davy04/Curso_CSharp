using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite seu nome Completo: ");
            string nomeComp = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa?: ");
            int quartos = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com seu ultimo nome, idade e altura (Mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine("A entrada de dados");
            Console.WriteLine(nomeComp);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            
        }
    }
}