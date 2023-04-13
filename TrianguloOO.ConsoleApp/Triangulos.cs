using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloOO.ConsoleApp
{
    internal class Triangulos
    {
        public int ladoA;
        public int ladoB;
        public int ladoC;

        public Triangulos(int ladoA, int ladoB, int ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        public string CalcularTriangulos()
        {
            if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
            {
                if (ladoA == ladoB && ladoA == ladoC)
                    return "Equilatero";
                else
                   if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                    return "Isosceles";
                else
                    return "Escaleno";
            }
            else
                return "Triangulo invalido!";
    }   }
}
