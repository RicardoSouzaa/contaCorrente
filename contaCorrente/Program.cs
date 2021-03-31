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

            //Declarando clientes
            Cliente ricardo = new Cliente()
            {
                nome = "Ricardo",
                cpf = "999.999.999-99",
                rg = "9.999.999-9",
                endereco = "rua A, 157"
            };

            Cliente raquel = new Cliente()
            {
                nome = "Raquel",
                cpf = "888.888.888-88",
                rg = "8.888.888-8",
                endereco = "rua B, 157"
            };

            //Declarando contas
            Conta contaRicardo = new Conta() // simoplificado com initializer
            {
                titular = ricardo,
                numero = 1,
                saldo = 1000.00
            };

            Conta contaRaquel = new Conta
            {
                numero = 1,
                titular = raquel,
                saldo = 2000.00
            };


            //logar na conta - Loging: ricardo senha: a123
            Logar();
            void Logar()
            {
                Console.WriteLine("Digite seu login.");
                string login = Console.ReadLine();
                Console.WriteLine("Digite sua senha.");
                string senha = Console.ReadLine();
                bool logCerto = contaRicardo.Login(login, senha);
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

            Console.WriteLine($"\n\nInformaçoes da conta: \n\nNumero da conta: {contaRicardo.numero} \nTitular: {ricardo.nome} \nSaldo: {contaRicardo.saldo}");

            //deposito
            Console.WriteLine("\n\nQuanto deseja depositar?");
            deposito = double.Parse(Console.ReadLine());
            contaRicardo.Depositar(deposito);
            Console.WriteLine($"\n\nDeposito de {deposito} realizado com sucesso");
            Console.WriteLine($"\nNovo saldo: {contaRicardo.saldo}");

            //saque
            Console.WriteLine("\n\nQuanto deseja sacar?");
            saque = double.Parse(Console.ReadLine());
            bool deuCerto = contaRicardo.Saca(saque);
            if (deuCerto)
            {
                Console.WriteLine("Saque realizado com sucesso");
                Console.WriteLine($"Novo saldo: {contaRicardo.saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }

            //transferir 
            Console.WriteLine("Quanto deseja transferir para raquel?");
            transferir = double.Parse(Console.ReadLine());
            contaRicardo.Transferir(transferir, contaRaquel); // valor, conta destino 
            Console.WriteLine($"\nnovo saldo ricardo: {contaRicardo.saldo} \nnovo saldo raquel {contaRaquel.saldo}");
            Console.ReadLine();
        }

    }
}
