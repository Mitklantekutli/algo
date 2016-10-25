namespace Algo.Sorting
{
    public class Insertion : ISorting
    {
        public SortingStats Sort(int[] a)
        {
            var stats = new SortingStats();

            //Outer
            for (int i = 0; i < a.Length-1; i++)
            {
                //Copy temp
                var tempIndex = i + 1;
                stats.Copies++;
                var t = a[tempIndex];
                

                for (int j = i; j >= 0; j--)
                {
                    stats.Compares++;
                    if (a[j] > t)
                    {
                        a[j + 1] = a[j];
                        stats.Copies++;
                        if (j == 0)
                        {
                            a[0] = t;
                            stats.Copies++;
                        }
                    }
                    else
                    {
                        a[j + 1] = t;
                        stats.Copies++;
                        break;
                    }
                }
            }


            return stats.Stop();
        }
    }
}
