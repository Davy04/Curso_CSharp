using System;
using System.Globalization;

namespace LojaTv // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);
            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Nome);

        }
    }
}