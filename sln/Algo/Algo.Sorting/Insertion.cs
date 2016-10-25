namespace Algo.Sorting
{
    public class Insertion : ISorting
    {
        public SortingStats Sort(int[] a)
        {
            var stats = new SortingStats();

            //outer - разделительный маркер
            for (var outer = 1; outer < a.Length; outer++)
            {
                stats.Copies++;
                var t = a[outer];//Помеченный элемент
                var inner = outer;//Начинаем копировать вправо с индекса помеченного элемента
                while (inner>0&&a[inner-1]>=t)//Сдвигаем вправо пока не найдем элемент который меньше помеченного
                {
                    stats.Compares++;
                    stats.Copies++;
                    a[inner] = a[inner - 1];//Копируем вправо
                    inner--;//Сдвигаем индекс влево
                }
                stats.Copies++;
                a[inner] = t;//Выставляем значение помеченного элемента в индекс последнего скопированного элемента
            }

            return stats.Stop();
        }
    }
}
