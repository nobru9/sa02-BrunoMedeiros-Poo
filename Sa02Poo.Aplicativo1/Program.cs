using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Situação de Aprendizagem 02 -POO.");
            Console.WriteLine("Bem vindo a companhia áerea VoeAirLines");
            Console.WriteLine("Para iniciarmos escolha uma das seguintes opções\n1- Iniciar 2- Fechar 3- Somar 4- Reiniciar");
            var menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    Console.WriteLine("Iniciando Aplicativo 1");
                    Console.WriteLine("Digite o valor do primeiro avião");
                    var valor1 = Console.ReadLine();
                    Console.WriteLine("Digite o valor do segundo avião");
                    var valor2 = Console.ReadLine();

                    Aplicativo1RN abo = new Aplicativo1RN();
                    double v1, v2;
                    v1 = double.Parse(valor1);
                    v2 = double.Parse(valor2);
                    var resposta = abo.CalcularSoma(v1, v2);
                    Console.WriteLine($"O valor total a ser pago será de: R${resposta}");

                    break;
            }
            Console.ReadKey();
        }
    }
}
