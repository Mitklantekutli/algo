using System;

namespace Algo.Sorting
{
    public class BubbleSorting : ISorting
    {
        public SortingStats Sort(int[] a)
        {
            var stats = new SortingStats();

            for (var i = a.Length - 1; i > 0; i--) //Внешний цикл (обратный)
            {
                for (var j = 0; j < i; j++) //Внутренний цикл (прямой)
                {
                    if (a[j] > a[j + 1]) //Если порядок нарушен
                    {
                        stats.Copies += 3;
                        a.Swap(j, j + 1); //Меняем местами
                    }
                    stats.Compares++;
                }
            }
            return stats.Stop();
        }
    }
}