using System;

namespace Ativivdade_18_Nullable_Thiago
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questão 1
            int? a = null;

            // Questão 2
            long? b = null;

            // Questão 3
            ushort? c = null;

            // Questão 4
            double? d = null;

            // Questão 5
            int? e = a ?? 34;

            // Questão 6
            long? f = b ?? 65000000;

            // Questão 7
            ushort? g = c ?? 500;

            // Questão 8
            double? h = d ?? 7.50;

            //Questão 9
            Console.WriteLine(e.GetValueOrDefault());

            //Questão 10
            Console.WriteLine(f.HasValue);

            //Questão 11
            Console.WriteLine(g.Value);
        }
    }
}
