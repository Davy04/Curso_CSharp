using System;


class Program
{
    static void Main(string[] args)
    {
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;

        Console.WriteLine("----------------------");
        Console.WriteLine("    1 - Álcool");
        Console.WriteLine("    2 - Gasolina");
        Console.WriteLine("    3 - Diesel");
        Console.WriteLine("    4 - Sair");
        Console.WriteLine("----------------------");

        Console.WriteLine("escolha sua opção: ");
        int op = int.Parse(Console.ReadLine());


        while (op != 4)
        {
            if (op == 1)
            {
                Console.WriteLine("Você escolheu: Álcool");
                alcool++;
            }
            else if (op == 2)
            {
                Console.WriteLine("Você escolheu: Gasolina");
                gasolina++;
            }
            else if (op == 3)
            {
                Console.WriteLine("Você escolheu: Diesel");
                diesel++;
            }
            else
            {
                Console.WriteLine("opção invalida");
            }
             op = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
    }
}