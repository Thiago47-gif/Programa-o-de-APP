using System;

namespace Questao_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[8];

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"\n#{i}: ");
                n[i] = int.Parse(Console.ReadLine());
            } 
            Console.WriteLine("Digite o valor de x e y (1 à 8):");
            Console.Write("X = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y = ");
            int y = int.Parse(Console.ReadLine());
            int soma = n[x] + n[y];
            Console.WriteLine($"\nSoma: {soma}");
        }
    }
}
