

namespace _8_ByteBank
{
    class CurrentAccount
    {
        public Client titular;
        public int agency;
        public int number;
        public double balance = 100.00;

        public bool Sacar(double value)
        {
            if (value > this.balance)
            {
                return false;
            }
            this.balance = this.balance - value;
            return true;
        }

        public void Depositar(double valor)
        {
            this.balance += valor;
        }

        public bool Transferir(double valor, CurrentAccount currentAccount)
        {
            if (this.balance < valor)
            {
                return false;
            }
            else
            {
                this.balance -= valor;
                currentAccount.Depositar(valor);
                return true;
            }
        }
    }
}