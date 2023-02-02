using Sa02Poo.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantAviao;
            Console.WriteLine("Companhia VoeAirLines!\nQuantos aviões você deseja sabendo que cada um suporta 17 assentos");
            quantAviao = double.Parse(Console.ReadLine());

            Aplicativo3RN rn3 = new Aplicativo3RN();
            var resposta = rn3.CalcularAssentos(quantAviao);
            Console.WriteLine($"A quantidade de assentos será de: {resposta}");
            Console.ReadKey();
        }
    }
}
