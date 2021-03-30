using System;

namespace contaCorrente
{
    class Program
    {
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


            Console.WriteLine($"Informaçoes da conta: \n\nNumero da conta: {ricardo.numero} \nTitular: {ricardo.titular} \nSaldo: {ricardo.saldo}");

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
            ricardo.Transferir(transferir, ricardo.saldo, raquel.saldo);
            Console.WriteLine($"\nnovo saldo ricardo: {ricardo.saldo} \nnovo saldo raquel {raquel.saldo}");
            Console.ReadLine();
        }

    }
}
