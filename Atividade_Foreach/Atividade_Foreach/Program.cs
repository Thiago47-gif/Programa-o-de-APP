using System;

namespace Atividade_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questao 1
            int[] num = new int[6] { 1, 2, 3, 4, 5, 6 };

            foreach (int n in num)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(); 
            // Questao 2
            string[] nome = new string[6] { "Thiago", "Bianca", "Diogo", "Diego", "Valdecy", "Aderli" };

            foreach (string n in nome)
            {
                Console.WriteLine(n);
            }
        }
    }
}
