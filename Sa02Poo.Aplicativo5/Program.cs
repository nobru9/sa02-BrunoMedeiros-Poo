using Sa02Poo.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal jan = 1000; decimal fev = 2000; decimal mar = 3000;
            Console.WriteLine($"- Faturamento trimestral VoeAirLines -\n\nValor obtido em janeiro: R${jan}\n\nValor obtido em fevereiro: R${fev}\n\nValor obtido em março: R${mar}");
            
            Aplicativo5RN rn5 = new Aplicativo5RN();
            var media = rn5.CalcularTrimestral(jan, fev, mar);
            Console.WriteLine($"\nA media do faturamento trimestral foi de: R${media}");
            Console.ReadKey();
        }
    }
}
