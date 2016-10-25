using System;
using System.Linq;

namespace Algo.Sorting
{
    class Program
    {
        static void Main()
        {
            var a = Generate(20000);
            Console.WriteLine("Total elements " + a.Length);
            Console.WriteLine();
            PrintSorting(new BubbleSorting(), a.ToArray(), "Bubble");
            PrintSorting(new Selection(), a.ToArray(), "Selecting");
            PrintSorting(new Insertion(), a.ToArray(), "Insertion");
        }

        private static void PrintSorting(ISorting sorting, int[] a, string name)
        {
            Console.WriteLine("Sorting " + name);
            var stats = sorting.Sort(a);
            PrintStats(stats);
            Console.WriteLine();
        }

        private static void PrintStats(SortingStats stats)
        {
            if (stats==null)
                return;
            Console.WriteLine("-------------------");
            Console.WriteLine("Compares: " + stats.Compares);
            Console.WriteLine("Copies: " + stats.Copies);
            Console.WriteLine("Time: " + stats.Timespan.TotalMilliseconds + " ms");
        }

        private static ISorting GetSorting()
        {
            return new Insertion();
        }

        public static int[] Generate(int count, int max = 100)
        {
            var a = new int[count];
            for (var i = 0; i < count; i++)
                a[i] = Rnd.Next(max);

            return a;
        }

        public static int[] GenerateOrdered(int count)
        {
            return Enumerable.Range(1, count).ToArray();
        }
        public static void PrintArr(int[] a)
        {
            Console.WriteLine(string.Join(", ", a));
        }

        private static readonly Random Rnd= new Random();
    }
}
