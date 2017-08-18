using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuplas.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // var sequence = Enumerable.Range(10, 1000000);

            var sequence = new List<int> { 132, 2, 5465, 4, 7, 8, 7 };
            var minmax = sequence.MinMax();
            Console.WriteLine($"Min: {minmax.min} Max: {minmax.max}");



            var (first, middle, last) = TuplasSimple.LookupName(2);

            Console.WriteLine($"Primeiro nome: {first} Nome do meio: {middle} e sobrenome:  {last}");

            Console.ReadKey();
        }
    }
}
