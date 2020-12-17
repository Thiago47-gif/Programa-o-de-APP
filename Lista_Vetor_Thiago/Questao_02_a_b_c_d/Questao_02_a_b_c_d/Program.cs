using System;

namespace Questao_02_a_b_c_d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[6];

            A[0] = 1;
            A[1] = 0;
            A[2] = 5;
            A[3] = -2;
            A[4] = -5;
            A[5] = 7;

            int valor = int.Parse(Console.ReadLine());
            int soma = valor + A[0] + A[1] + A[5];
            Console.WriteLine(soma);

            A[4] = 100; 

            foreach (int i in A)
            {
                Console.WriteLine(i);
            } 
        }
    }
}
