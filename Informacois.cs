using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ContaCorrente
{
    class Informacoes
    {

        public double Saldo
        {
            get;
            private set;
        }
        public string Titular
        {
            get;
            set;
        }

        public int NumeroConta
        {
            get;
            private set;
        }
        public Informacoes(string titular, int numeroConta)
        {
            Titular = titular;
            NumeroConta = numeroConta;
        }
        public Informacoes(string titular, int numeroConta, double saldo) : this(titular, numeroConta)
        {
            Saldo = saldo;
        }
        public void setDeposito(double valor)
        {
            Saldo += valor;
        }
        public void setSaque(double valor)
        {
            
            if (valor > Saldo)
            {
                Console.WriteLine("Você não tem limite suficiente para saque.");
            }
            else
            {
                Saldo -= valor + 5;

            }
        }
        public override string ToString()
        {
            return ($"Titular: {Titular} \t número da conta: {NumeroConta} \t saldo atual: {Saldo:f2}");
        }

    }
}