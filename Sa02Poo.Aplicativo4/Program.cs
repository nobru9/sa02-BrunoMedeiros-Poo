using Sa02Poo.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal clientes = 10;
            Console.WriteLine("Programa para clientes especiais VoeAirLines");
            Aplicativo4RN rn4 = new Aplicativo4RN();
            var resposta = rn4.DivividirClientes(clientes);
            Console.WriteLine($"O valor dividido entre os clientes especiais da companhia será de: {resposta}");
            Console.ReadKey();
        }
    }
}
