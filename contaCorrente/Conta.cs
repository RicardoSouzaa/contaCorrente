namespace contaCorrente
{
    class Conta
    {
        public int numero;
        public double saldo;
        public Cliente titular;


        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Transferir(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Depositar(valor);
            }

        }

        public bool Login(string login, string senha)
        {
            if (login == "ricardo" && senha == "a123")
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
