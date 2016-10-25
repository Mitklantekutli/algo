namespace Algo.Sorting
{
    public class Selection : ISorting
    {
        public SortingStats Sort(int[] a)
        {
            var stats = new SortingStats();

            for (var currentIndex = 0; currentIndex < a.Length-1; currentIndex++)//Проходимся до последнего элемента
            {
                var minIndex = currentIndex;//Считаем текущий элемент минимальным и берем его индекс
                for (var j = currentIndex; j < a.Length; j++)//Ищем минимальный элемент, начиная с текущего
                {
                    stats.Compares++;
                    if (a[minIndex] > a[j])//Нашли новый минимум
                        minIndex = j;
                }
            
                a.Swap(currentIndex, minIndex);//Меняем местами текущий элемент с минимальным
                stats.Copies += 3;
            }
            return stats.Stop();
        }
    }
}
