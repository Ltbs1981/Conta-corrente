using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            int acao = 0;
            double saldo = 0;
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
                    Console.WriteLine("Informe o valor do depósito");
                    break;
                    case 4:
                        Console.WriteLine("Obrigado");
                        break;
                    default:
                    Console.WriteLine("Digite uma opção válida");
                    break;


            }
        }
                void FazerSaque() {
                            Console.WriteLine("Qual o valor do saque?");
                        double valorTrasferencia = double.Parse(Console.ReadLine());
                if (valorTrasferencia > saldo)
                {
                    Console.WriteLine("Você não tem saldo suficiente para saque");
                }
                else
                {
                    double taxa = 5;
                    saldo -= valorTrasferencia +taxa;
                }
                         }
            } 
        }
        
    }

