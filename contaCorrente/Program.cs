using System;

namespace contaCorrente
{
    class Program

    {
        static public void Limpar()
        {
            Console.Clear();
        }
        static void Main(string[] args)
        {
            double saque, deposito, transferir;

            Conta ricardo = new Conta();
            ricardo.numero = 1;
            ricardo.titular = "Ricardo";
            ricardo.saldo = 150.00;

            Conta raquel = new Conta();
            raquel.numero = 1;
            raquel.titular = "raquel";
            raquel.saldo = 200.00;


            //logar na conta
            Logar();
            void Logar()
            {
                Console.WriteLine("Digite seu login.");
                string login = Console.ReadLine();
                Console.WriteLine("Digite sua senha.");
                string senha = Console.ReadLine();
                bool logCerto = ricardo.Login(login, senha);
                if (logCerto)
                {
                    Console.WriteLine("\n\nLogin realizado com sucesso");
                }
                else
                {
                    Console.WriteLine("Login ou senha inválida, tente novamente");
                    Console.ReadLine();
                    Limpar();
                    Logar();
                }

            }

            //informações da conta

            Console.WriteLine($"\n\nInformaçoes da conta: \n\nNumero da conta: {ricardo.numero} \nTitular: {ricardo.titular} \nSaldo: {ricardo.saldo}");

            //deposito
            Console.WriteLine("\n\nQuanto deseja depositar?");
            deposito = double.Parse(Console.ReadLine());
            ricardo.Depositar(deposito);
            Console.WriteLine($"\n\nDeposito de {deposito} realizado com sucesso");
            Console.WriteLine($"\nNovo saldo: {ricardo.saldo}");

            //saque
            Console.WriteLine("\n\nQuanto deseja sacar?");
            saque = double.Parse(Console.ReadLine());
            bool deuCerto = ricardo.Saca(saque);
            if (deuCerto)
            {
                Console.WriteLine("Saque realizado com sucesso");
                Console.WriteLine($"Novo saldo: {ricardo.saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }

            //transferir 
            Console.WriteLine("Quanto deseja transferir para raquel?");
            transferir = double.Parse(Console.ReadLine());
            ricardo.Transferir(transferir, raquel); // valor, conta destino / sem o REF o valor nao vai para o objeto raquel...
            Console.WriteLine($"\nnovo saldo ricardo: {ricardo.saldo} \nnovo saldo raquel {raquel.saldo}");
            Console.ReadLine();
        }

    }
}
