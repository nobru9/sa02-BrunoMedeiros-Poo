using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.RegraDeNegocio
{
    public class Aplicativo6RN
    {
        public double CalcularAviao1(double aviao1, double valorUnit1)
        {
            return aviao1 * valorUnit1;

        }
        public double CalcularAviao2(double aviao2, double valorUnit2)
        {
            return aviao2 * valorUnit2;
        }
        public double CalcularAviao3(double aviao3, double valorUnit3)
        {
            return aviao3 * valorUnit3;
        }
        public double CalcularAviao4(double aviao4, double valorUnit4)
        {
            return aviao4 * valorUnit4;
        }
        public double CalcularTotal(double quantAviao1, double quantAviao2, double quantAviao3, double quantAviao4)
        {
            return quantAviao1 + quantAviao2 + quantAviao3 + quantAviao4;
        }
    }
}
