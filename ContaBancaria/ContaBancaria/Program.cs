using System;
using System.Globalization;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Entre com o Número da Conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da Conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c = new Conta(numero, titular, depositoInicial);
            } else
            {
                c = new Conta(numero, titular);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(c);
        }
    }
}