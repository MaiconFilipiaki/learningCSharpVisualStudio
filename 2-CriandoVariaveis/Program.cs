using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exec Programa 2 - Criando Variaveis");

            int idade = 32;
            double t = 44.4;
            string nome = "Maicon Douglas Filipiaki";
            string[] lista = { "Maicon", "Douglas" };

            Console.WriteLine(idade.ToString() + " " + nome + " " + lista[0] + " " + t);

            Console.WriteLine("Program Fim, tecle enter...");
            Console.ReadLine();
        }
    }
}
