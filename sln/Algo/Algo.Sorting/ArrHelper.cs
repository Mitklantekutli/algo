using System;

namespace Algo.Sorting
{
    public static class ArrHelper
    {
        public static void Swap(this int[] arr, int i, int j)
        {
            var t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }
        public static void Print(this int[] a)
        {
            Console.WriteLine(string.Join(", ", a));
        }
    }
}