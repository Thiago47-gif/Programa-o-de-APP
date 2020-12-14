using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Fixação.Entities
{
    class ContaEmpresa : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresa()
        {
        }

        public ContaEmpresa(int numero, string titular, double saldo, double limiteEmprestimo)
           : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                Saldo += valor;
            }
        }
    }
}
