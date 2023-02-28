using System.Globalization;

Console.WriteLine(" CÓDIGO  |  ESPECIFICAÇÃO  | PREÇO");
Console.WriteLine("-----------------------------------");
Console.WriteLine("   1     Cachorro quente   R$ 4.00");
Console.WriteLine("   2     X-Salada          R$ 4.50");
Console.WriteLine("   3     X-Bacon           R$ 5.00");
Console.WriteLine("   4     Torrada Simples   R$ 2.00");
Console.WriteLine("   5     Refrigerante      R$ 1.50");
Console.WriteLine("-----------------------------------");
Console.WriteLine(" ");
Console.Write("Digite o código do pedido: ");
int codigo = int.Parse(Console.ReadLine());
Console.Write("Digite a Quantidade: ");
int quantidade = int.Parse(Console.ReadLine());

double valor;
double total;

if (codigo == 1)
{
    total = quantidade * 4.0;
}
else if (codigo == 2)
{
    total = quantidade * 4.5;
}
else if (codigo == 3)
{
    total = quantidade * 5.0;
}
else if (codigo == 4)
{
    total = quantidade * 2.0;
}
else
{
    total = quantidade * 1.5;
}

Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));