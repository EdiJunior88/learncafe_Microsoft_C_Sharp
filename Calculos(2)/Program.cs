using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double soma;
            String operacao;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" ");

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            soma = numero1 + numero2;

            Console.Write(" ");

            Console.Write("O resultado é: " + soma);
            Console.ReadKey();
        }
    }
}
