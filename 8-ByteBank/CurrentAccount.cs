

namespace _8_ByteBank
{
    class CurrentAccount
    {
        public Client Titular { get; set; }
        public int Agency { get; set; }
        public int Number { get; set; }

        private double _balance = 100.00;

        public double Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                if (value > 0)
                {
                    this._balance = value;
                }
            }
        }


        public CurrentAccount(int agency, int number)
        {
            this.Agency = agency;
            this.Number = number;
        }

        public bool Sacar(double value)
        {
            if (value > this._balance)
            {
                return false;
            }
            this._balance = this._balance - value;
            return true;
        }

        public void Depositar(double valor)
        {
            this._balance += valor;
        }

        public bool Transferir(double valor, CurrentAccount currentAccount)
        {
            if (this._balance < valor)
            {
                return false;
            }
            else
            {
                this._balance -= valor;
                currentAccount.Depositar(valor);
                return true;
            }
        }
    }
}