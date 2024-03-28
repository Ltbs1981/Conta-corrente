using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double valor;
            int numeroConta;
            int acao;
            Console.WriteLine("Bem vindo ao Banco do futuro!");
            Informacoes info;
            Console.WriteLine("Digite o nome do titular.");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o número da conta.");
            numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja depositar um saldo inicial na conta? 1 sim, 2 não.");
            acao = int.Parse(Console.ReadLine());
            if (acao == 1)
            {
                Console.WriteLine("Digite o Valor inicial.");
                valor = double.Parse(Console.ReadLine());
                info = new Informacoes(nome, numeroConta, valor);
                Console.WriteLine("***Conta criada com sucesso***");
            }
            else
            {
                info = new Informacoes(nome, numeroConta);
                Console.WriteLine("***Conta criada com sucesso***");
                
            }
            while (acao != 4)
            {
                Console.WriteLine($"Informações da conta: {info} \n");
                Console.WriteLine("Escolha a sua operação:\n Consultar saldo, digite 1\n Fazer um saque, digite 2\n Fazer um depósito, digite 3 \n Sair, digite 4");
                acao = int.Parse(Console.ReadLine());

                switch (acao)
                {
                    case 1:
                        Console.WriteLine(info.Saldo);
                        break;
                    case 2:
                        {
                            Console.WriteLine("Digite o valor do saque.");
                            valor = double.Parse(Console.ReadLine());
                            info.setSaque(valor);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Digite o valor do depósito.");
                            valor = double.Parse(Console.ReadLine());
                            info.setDeposito(valor);
                            break;
                        }
                    case 4:
                        Console.WriteLine("Obrigado");
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }
            }

        }
    }
}
