using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3WF
{
    internal class Quadrado
    {
        private double diagonal;

        public Quadrado(double diagonal)

        {
            this.diagonal = diagonal;
        }

        public Quadrado()

        {
            this.diagonal = 0;
        }

        public void setDiagonal (double diagonal)
        { 
            this.diagonal = diagonal;
        }

        public double getDiagonal()
        {
            return this.diagonal; 
        }

        public double CalcularArea()

        {

            Double lado = diagonal / Math.Sqrt(2);

            Double area = lado * lado;

            return area;

        }
    }
}
