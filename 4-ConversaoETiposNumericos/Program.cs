using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversaoETiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Opa, estou aqui meu caro");

            double salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            long idade = 13000000000;

            short qtdPr  = 15000;

            float altura = 1.80f;


            Console.WriteLine("Deu por hoje neh meu caro ? Da um enter ai...");
            Console.ReadLine();

        }
    }
}
