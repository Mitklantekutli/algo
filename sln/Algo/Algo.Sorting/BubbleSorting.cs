using System;

namespace Algo.Sorting
{
    public class BubbleSorting : ISorting
    {
        public SortingStats Sort(int[] a)
        {
            var stats = new SortingStats();

            var outer = a.Length-1;
            for (var i = outer; i > 0; i--) //������� ���� (��������)
            {
                for (var j = 0; j < i; j++) //���������� ���� (������)
                {
                    //������� �������?
                    if (a[j] > a[j + 1])
                    {
                        a.Swap(j, j + 1);
                        stats.Copies += 3;
                    }
                    stats.Compares++;
                }
            }
            return stats.Stop();
        }
    }
}