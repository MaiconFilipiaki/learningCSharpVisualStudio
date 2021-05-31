using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ControleFluxo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("EXE");
            int idade = 23;
            int teste;
            string testeString;
            char testeChar;
            bool testeBool;

            bool t = true;
            if (idade >= 18)
            {
                Console.WriteLine("Maior");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Menor");
            }
            else
            {
                Console.WriteLine("Acho que fez errado algo, nao acha ?");
            }

            if (t)
            {
                Console.WriteLine("Verdade");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();

        }
    }
}
