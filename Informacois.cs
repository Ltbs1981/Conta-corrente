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
            Saldo -= valor + 5;
        }
        public override string ToString()
        {
            return ($"Titular: {Titular} \n número da conta: {NumeroConta} \n saldo atual: {Saldo.ToString("C2")}");
        }

    }
}