using System.Globalization;

namespace LojaTv
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome + ",  $" + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " + Quantidade + " Unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
