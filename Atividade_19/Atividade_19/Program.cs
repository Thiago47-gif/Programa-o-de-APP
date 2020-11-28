using System;

namespace Atividade_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Quartos[] x = new Quartos[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel #"+ i +":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine()); 

                x[quarto] = new Quartos(nome, email, quarto);
                Console.WriteLine();
            }
            Console.WriteLine("Quartos ocupados:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(x[i]);


            }
        }
    }
}
