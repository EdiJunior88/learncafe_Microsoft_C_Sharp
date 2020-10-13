using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome;
            nome = new string[4];

            nome[0] = "Hugo";
            nome[1] = "Vasconcelos";
            nome[2] = "De";
            nome[3] = "Freitas";

            for(int i = 0; i < 4; i++)
            {
                Console.Write(nome[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
