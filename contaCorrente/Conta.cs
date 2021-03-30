namespace contaCorrente
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

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

        public void Transferir(double valor , double destino)
        {
            this.saldo -= valor;
            destino += valor;

            
        }
    }
}
