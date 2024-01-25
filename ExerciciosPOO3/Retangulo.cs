using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO3
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt((Altura * Altura) + (Largura * Largura));
        }
        public override string ToString()
        {
            return ($"Area = {Area().ToString("F2")} " +
                $"\nPerímetro = {Perimetro().ToString("F2")} " +
                $"\nDiagonal = {Diagonal().ToString("F2")}");
        }
    }
}
