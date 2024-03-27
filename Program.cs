using System;

namespace ContaCorrente
{
    class Program
    {
        static double saldo = 0; // Movido para fora do método Main para ser acessível em toda a classe

        static void Main(string[] args)
        {
            int acao = 0;
            Console.WriteLine("Boas vindas ao Banco do Futuro");
            Console.WriteLine("Informe o seu nome para abrir a sua conta.");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o número da sua conta com 5 dígitos");
            string numeroConta = Console.ReadLine();
            Console.WriteLine("Informe o valor de depósito inicial");
            saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("***Conta aberta com sucesso***");

            while (acao != 4)
            {
                Console.WriteLine($"Titular da conta: {nome}\tConta: {numeroConta}\tSaldo: {saldo}");
                Console.WriteLine("Escolha a sua operação:\n Consultar saldo, digite 1\n Fazer um saque, digite 2\n Fazer um depósito, digite 3 \n Sair, digite 4");
                acao = int.Parse(Console.ReadLine());

                switch (acao)
                {
                    case 1:
                        Console.WriteLine(saldo);
                        break;
                    case 2:
                        FazerSaque();
                        break;
                    case 3:
                        FazerDeposito();
                        break;
                    case 4:
                        Console.WriteLine("Obrigado");
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }
            }
        }

        static void FazerSaque()
        {
            Console.WriteLine("Qual o valor do saque?");
            double valorSaque = double.Parse(Console.ReadLine());
            double taxa = 5; // A taxa deve ser cobrada somente se o saque for bem-sucedido
            if (valorSaque > saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente para saque");
            }
            else
            {
                saldo -= valorSaque + taxa;
                Console.WriteLine($"Saque de {valorSaque} efetuado com sucesso.");
            }
        }

        static void FazerDeposito()
        {
            Console.WriteLine("Informe o valor do depósito");
            double valorDeposito = double.Parse(Console.ReadLine());
            saldo += valorDeposito;
            Console.WriteLine($"Depósito de {valorDeposito} efetuado com sucesso.");
        }
    }
}
