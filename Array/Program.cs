using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            //Finalização do código da aula 09 e explicação sobre ARRAYS

            double numero;
            double total;
            string operacao;

            total = 0;
            operacao = "+";

            while(operacao != "=")
            {
                Console.Write("Entee com um valor: ");
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

                Console.Write("Digite a operação: ");
                operacao = Console.ReadLine();
            }

            Console.WriteLine("\nO resultado é: " + total);
            Console.ReadKey();
        }
    }
}
