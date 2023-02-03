using Sa02Poo.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02.Aplicativo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compra de Frotas VoeAirLines!");
            Console.WriteLine("Informe o valor que você deseja.");
            double av1 = Console.ReadLine();

            Console.WriteLine("Quantos aviões desse modelo quer adquirir?");
            double valorUnit = Console.ReadLine();

            Console.WriteLine("Informe o valor que você deseja.");
            double av2 = Console.ReadLine();

            Console.WriteLine("Quantos aviões desse modelo quer adquirir?");
            double valorUnit = Console.ReadLine();

            Console.WriteLine("Informe o valor que você deseja.");
            double av3 = Console.ReadLine();

            Console.WriteLine("Quantos aviões desse modelo quer adquirir?");
            double valorUnit = Console.ReadLine();

            Console.WriteLine("Informe o valor que você deseja.");
            double av4 = Console.ReadLine();

            Console.WriteLine("Quantos aviões desse modelo quer adquirir?");
            double valorUnit = Console.ReadLine();

            Aplicativo6RN rn6 = new Aplicativo6RN();
            double aviao1;
            aviao1 = double.Parse(av1);
            rn6.CalcularAviao1(aviao1, valorUnit);

            double aviao2;
            aviao2 = double.Parse(av2);
            rn6.CalcularAviao2(aviao1, valorUnit);

            double aviao3;
            aviao3 = double.Parse(av3);
            rn6.CalcularAviao3(aviao3, valorUnit);

            double aviao4;
            aviao4 = double.Parse(av3);
            rn6.CalcularAviao4(aviao4, valorUnit);

        }
    }
}
