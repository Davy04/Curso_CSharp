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
            Console.WriteLine("");

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
            Console.WriteLine("");

            Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            c.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
            Console.WriteLine("");

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            c.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

        }
    }
}