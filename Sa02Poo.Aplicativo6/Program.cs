using Sa02Poo.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compra de Frotas VoeAirLines!");
            Console.WriteLine("Informe o valor que você deseja.");
            double aviao1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos aviões desse modelo quer adquirir?");
            double valorUnit1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor que você deseja.");
            double aviao2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos aviões desse modelo quer adquirir?");
            double valorUnit2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor que você deseja.");
            double aviao3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos aviões desse modelo quer adquirir?");
            double valorUnit3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor que você deseja.");
            double aviao4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos aviões desse modelo quer adquirir?");
            double valorUnit4 = double.Parse(Console.ReadLine());

            Aplicativo6RN rn6 = new Aplicativo6RN();
            var quantAviao1 = rn6.CalcularAviao1(aviao1, valorUnit1);

            var quantAviao2 = rn6.CalcularAviao2(aviao2, valorUnit2);

            var quantAviao3 = rn6.CalcularAviao3(aviao3, valorUnit3);

            var quantAviao4 = rn6.CalcularAviao3(aviao4, valorUnit4);

            var total = rn6.CalcularTotal(quantAviao1, quantAviao2, quantAviao3, quantAviao4);

            Console.WriteLine($"Fim do processo de compra. O valor total a ser pago será de R${total}");
            Console.ReadLine();
        }
    }
}
