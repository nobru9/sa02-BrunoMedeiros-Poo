using Sa02Poo.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compras de peças aviárias VoeAirLines informe quantas peças deseja comprar (1 a 5)");
            var menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    Console.WriteLine("Informe o valor da primeira peça: ");
                    double peca1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O valor total a ser pago pela peça será de: R${peca1}");
                    Console.ReadLine();

                    break;

            }
            switch (menu)
            {
                case "2":
                    Console.WriteLine("Informe o valor da primeira peça: ");
                    double peca1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da segunda peça: ");
                    double peca2 = double.Parse(Console.ReadLine());

                    var total = peca1 + peca2;

                    Console.WriteLine($"O valor total a ser pago pelas peças será de: R${total}");
                    Console.ReadLine();

                    break;
            }
            switch (menu)
            {
                case "3":
                    Console.WriteLine("Informe o valor da primeira peça: ");
                    double peca1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da segunda peça: ");
                    double peca2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da terceira peça: ");
                    double peca3 = double.Parse(Console.ReadLine());

                    var total = peca1 + peca2 + peca3;

                    Console.WriteLine($"O valor total a ser pago pelas peças será de: R${total}");
                    Console.ReadLine();

                    break;
            }
            switch (menu)
            {
                case "4":

                    Console.WriteLine("Informe o valor da primeira peça: ");
                    double peca1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da segunda peça: ");
                    double peca2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da terceira peça: ");
                    double peca3 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da quarta peça: ");
                    double peca4 = double.Parse(Console.ReadLine());

                    var total = peca1 + peca2 + peca3 + peca4;  

                    Console.WriteLine($"O valor total a ser pago pelas peças será de: R${total}");
                    Console.ReadLine();

                    break;
            } 
            switch (menu)
            {
                case "5":

                    Console.WriteLine("Informe o valor da primeira peça: ");
                    double peca1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da segunda peça: ");
                    double peca2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da terceira peça: ");
                    double peca3 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da quarta peça: ");
                    double peca4 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da quinta peça: ");
                    double peca5 = double.Parse(Console.ReadLine());

                    Aplicativo7RN rn7 = new Aplicativo7RN();

                    var total = rn7.CalcularPecas(peca1, peca2, peca3, peca4, peca5);

                    Console.WriteLine($"O valor total a ser pago pelas peças será de: R${total}");
                    Console.ReadLine();

                    break;
            }

        }
    }
}
