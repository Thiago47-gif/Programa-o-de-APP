using System;

namespace Matriz_Thiago
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int n = int.Parse(Console.ReadLine());
            

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++) 
            {
                string[] numeros = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(numeros[j]);
                }
            }

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
