using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.RegraDeNegocio
{
    public class Aplicativo5RN
    {
        public decimal CalcularTrimestral(decimal jan, decimal fev, decimal mar)
        {
            return (jan + fev + mar) / 3;
        }
    }
}
