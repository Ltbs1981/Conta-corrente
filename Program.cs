﻿using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            int acao = 0;
            double saldo = 3500;

            do
            {

                Console.WriteLine("Boas vindas ao Banco do Futuro");
                Console.WriteLine("Escolha a sua operação:\n Consultar saldo, digite 1\n Fazer uma transferência, digite 2\n Sair, digite 3");
                acao = int.Parse(Console.ReadLine());

                switch (acao)
                {
                    case 1:
                        Console.WriteLine(saldo);
                        break;
                    case 2:
                        Console.WriteLine("Para onde você quer transferir ?");
                        break;
                    case 3:
                        Console.WriteLine("Obrigado..");
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;

                }
            } while (acao != 3);

        }
    }
}
