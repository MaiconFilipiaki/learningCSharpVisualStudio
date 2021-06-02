using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ByteBank
{
    class Program
    {
        private int GenerateNumberRandom()
        {
            Random random = new Random();
            return random.Next(0, 10000);
        }
        static void Main(string[] args)
        {
            Client client = new Client();
            client.cpf = "00000000";
            client.nome = "Maicon Douglas Filipiaki";
            client.profissao = "Arquiteto";
            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.titular = client;

            Console.WriteLine(currentAccount.titular.nome);
            //CurrentAccount currentAccount = new CurrentAccount();
            //currentAccount.titular = "Maicon";

            //CurrentAccount currentAccount2 = new CurrentAccount();
            //currentAccount2.titular = "Maicon";

            // Console.WriteLine(currentAccount.balance);
            // Console.WriteLine(currentAccount.ToString());
            //Console.WriteLine("ANTES DO SAQUE " + currentAccount.balance);
            //currentAccount.Sacar(150);
            //Console.WriteLine("DEPOIS DO SAQUE " + currentAccount.balance);

            Console.ReadLine();


        }
    }
}
