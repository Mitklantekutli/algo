namespace Algo.Sorting
{
    public class Selection : ISorting
    {
        public SortingStats Sort(int[] a)
        {
            var stats = new SortingStats();

            //Outer
            for (int i = 0; i < a.Length; i++)
            {
                var minIndex = i;
                //Inner
                for (int j = i; j < a.Length; j++)
                {
                    if (a[minIndex] > a[j])
                        minIndex = j;
                    stats.Compares++;
                }
                //Swap current with min    
                a.Swap(i, minIndex);
                stats.Copies += 3;
            }
            return stats.Stop();
        }
    }
}
