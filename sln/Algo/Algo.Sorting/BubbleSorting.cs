using System;

namespace Algo.Sorting
{
    public class BubbleSorting : ISorting
    {
        public SortingStats Sort(int[] a)
        {
            var stats = new SortingStats();

            for (var i = a.Length - 1; i > 0; i--) //������� ���� (��������)
            {
                for (var j = 0; j < i; j++) //���������� ���� (������)
                {
                    if (a[j] > a[j + 1]) //���� ������� �������
                    {
                        stats.Copies += 3;
                        a.Swap(j, j + 1); //������ �������
                    }
                    stats.Compares++;
                }
            }
            return stats.Stop();
        }
    }
}