using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Fixação.Entities
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta() // Construtor padrão
        {

        }
        //Construlor com argumentos
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double valor)
        {
            Saldo = Saldo - valor; //Ou Saldo -= valor;
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor; //Ou Saldo += valor;
        }


    }
}
