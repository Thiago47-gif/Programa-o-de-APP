using System;
using Heranca_Fixação.Entities;

namespace Heranca_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(9015, "Naruto", 500.0);
            ContaEmpresa conta2 = new ContaEmpresa(9016, "Hinata", 500.0, 300.0);

            conta.Saque(10.0);
            conta2.Saque(10.0);
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta2.Saldo);

        }
    }
}
