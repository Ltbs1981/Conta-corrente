using System;

namespace ContaCorrente
{
    class Informacoes
    {
        public double Saldo { get; private set; }
        public string Titular { get; set; }
        public int NumeroConta { get; private set; }

        public Informacoes(string titular, int numeroConta)
        {
            Titular = titular;
            NumeroConta = numeroConta;
        }

        public Informacoes(string titular, int numeroConta, double saldo) : this(titular, numeroConta)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!");
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Você não tem limite suficiente para saque.");
            }
            else
            {
                Saldo -= valor + 5; //5 é a taxa de saque
                Console.WriteLine("Saque realizado com sucesso.");
            }
        }

        public override string ToString()
        {
            return ($"Titular: {Titular}\tNúmero da conta: {NumeroConta}\tSaldo atual: {Saldo:f2}");
        }
    }
}
