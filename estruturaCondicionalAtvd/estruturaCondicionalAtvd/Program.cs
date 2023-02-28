Console.Write("Digite o horario de inicio: ");
int horaInicial = int.Parse(Console.ReadLine());

Console.Write("Digite o horario de termino: ");
int horaFinal = int.Parse(Console.ReadLine());

int duracao;

if (horaInicial < horaFinal)
{
    duracao = horaFinal - horaInicial;
}
else
{
    duracao = 24 - horaInicial + horaFinal;
}

Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");