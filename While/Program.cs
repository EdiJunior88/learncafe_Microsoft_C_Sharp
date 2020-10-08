using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {

            //CÓDIGO NÃO FINALIZADO

            double numero;
            double total;
            String operacao;

            total = 0;
            operacao = "+";

            while (operacao != "=")
            {
                Console.Write("Entre com um valor ");
                numero = Convert.ToDouble(Console.ReadLine());

                switch (operacao)
                {
                    case "+": total = total + numero;
                        break;

                    case "-": total = total - numero;
                        break;

                    case "*": total = total * numero;
                        break;

                    case "/": total = total / numero;
                        break;
                }


            }

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a operação: ");
            operacao = Console.ReadLine();

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" ");

            Console.WriteLine("O resultado é: ");
            Console.ReadKey();
        }
    }
}
