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
            client.Cpf = "00000000";
            client.Nome = "Maicon Douglas Filipiaki";
            client.Profissao = "Arquiteto";
            CurrentAccount currentAccount = new CurrentAccount(1, 34234234);
            currentAccount.Titular = client;
            // currentAccount.Balance = 10;

            Console.WriteLine(currentAccount.Titular.Nome);
            Console.WriteLine(currentAccount.Balance);
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
