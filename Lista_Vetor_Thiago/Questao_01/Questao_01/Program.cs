using System;

namespace Questao_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Valor {i}: ");
                n[i] = int.Parse(Console.ReadLine());
            }

            foreach (int a in n)
            {
                Console.WriteLine(a);
            }


        }
    }
}
