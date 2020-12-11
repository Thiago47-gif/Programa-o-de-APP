using System;

namespace Matriz_Thiago
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int n;
            n = 3;

            int[,] matriz = new int[n, n];

            matriz[0, 0] = 7;
            matriz[0, 1] = -4;
            matriz[0, 2] = 2;
            matriz[1, 0] = 8;
            matriz[1, 1] = -6;
            matriz[1, 2] = -8;
            matriz[2, 0] = 3;
            matriz[2, 1] = 1;
            matriz[2, 2] = -1;

            Console.WriteLine($"Valor de n: {n}\n");
            Console.WriteLine($"{matriz[0, 0]} {matriz[0, 1]} {matriz[0, 2]}");
            Console.WriteLine($"{matriz[1, 0]} {matriz[1, 1]} {matriz[1, 2]}");
            Console.WriteLine($"{matriz[2, 0]} {matriz[2, 1]} {matriz[2, 2]}");

            Console.WriteLine("\nMain diagonal: ");
            Console.WriteLine($"{matriz[0, 0]} {matriz[1, 1]} {matriz[2, 2]}\n");

            foreach (int i in matriz)
            {
                if(i < 0)
                {
                    cont = cont + 1;
                }
            }
             
            Console.WriteLine($"Negative numbers = {cont}");

            Console.ReadKey();
        }
    }
}
