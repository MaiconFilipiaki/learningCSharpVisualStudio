using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_WhileAndFor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Opa, tudo bem meu caro ?");

            double valorInvestido = 1000;
            int contador = 1;

            while (contador <= 12 ) {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;

                Console.WriteLine("MES: " + contador + " Valor: " + valorInvestido);
                contador += 1;
            }

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("OPA TESTE: " + i);
                if (i == 10)
                {
                    Console.WriteLine("BREAK: " + i);
                    break;
                }
            }

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("FOR FORA PRIMEIRO");
                for (int a = 0; a < 5; a++)
                {
                    Console.WriteLine("FOR DENTRO");
                }
                Console.WriteLine("FOR FORA ULTIMO");
            }

            Console.WriteLine("END");
            Console.ReadLine();

        }
    }
}
