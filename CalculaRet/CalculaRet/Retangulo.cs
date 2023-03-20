using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaRet
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;
        public double Area;
        public double Perimetro;
        public double Diagonal;


        public double CalculaArea()
        {
            Area = Largura * Altura;
            return Area;
        }

        public double CalculaPerimetro()
        {
            Perimetro = Altura * 2 + Largura * 2;
            return Perimetro;
        }

        public double CalculaDiagonal()
        {
            Diagonal = Math.Sqrt(Math.Pow(Largura, 2.0) + Math.Pow(Altura, 2.0));
            return Diagonal;
        }
    }
}
