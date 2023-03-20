using System;
using System.Globalization;

namespace CalculaRet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            Console.Write("Largura: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: " + ret.CalculaArea().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + ret.CalculaPerimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + ret.CalculaDiagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}