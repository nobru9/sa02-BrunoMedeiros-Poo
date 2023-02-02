using Sa02Poo.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anoAtual;
            Console.WriteLine("Digite o ano atual");
            anoAtual = int.Parse(Console.ReadLine());

            Aplicativo2RN rn2 = new Aplicativo2RN();
            var resposta = rn2.CalcularAno(anoAtual);
            Console.WriteLine($"O valor da subtração será de: {resposta}");
            Console.ReadLine();
            
        }
    }
}
