using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Banco do futuro!");
            Console.WriteLine("Digite o nome do titular:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o número da conta:");
            int numeroConta = int.Parse(Console.ReadLine());

            Informacoes conta;
            Console.WriteLine("Deseja depositar um saldo inicial na conta? (1 para sim, 2 para não)");
            int acao = int.Parse(Console.ReadLine());

            if (acao == 1)
            {
                Console.WriteLine("Digite o Valor inicial:");
                double valorInicial = double.Parse(Console.ReadLine());
                conta = new Informacoes(nome, numeroConta, valorInicial);
                Console.WriteLine("***Conta criada com sucesso***");
            }
            else
            {
                conta = new Informacoes(nome, numeroConta);
                Console.WriteLine("***Conta criada com sucesso***");
            }

            while (acao != 4)
            {
                Console.WriteLine($"Informações da conta: {conta} \n");
                Console.WriteLine("Escolha a sua operação:\n 1. Consultar saldo\n 2. Fazer um saque\n 3. Fazer um depósito\n 4. Sair");
                acao = int.Parse(Console.ReadLine());

                switch (acao)
                {
                    case 1:
                        Console.WriteLine($"Saldo atual: {conta.Saldo}");
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor do saque:");
                        double valor= double.Parse(Console.ReadLine());
                        conta.Sacar(valor);
                        break;
                    case 3:
                        Console.WriteLine("Digite o valor do depósito:");
                        valor = double.Parse(Console.ReadLine());
                        conta.Depositar(valor);
                        break;
                    case 4:
                        Console.WriteLine("Obrigado! Lembre-se, o futuro começa amanhã...");
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }
            }
        }
    }
}
