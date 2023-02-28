Console.Write("Digite o primeiro valor: ");
int v1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
int v2 = int.Parse(Console.ReadLine());

if (v1 % v2 == 0 || v2 % v1 == 0)
{
    Console.WriteLine("São Multiplos!");
} else
{
    Console.WriteLine("Não são Multiplos!");
}