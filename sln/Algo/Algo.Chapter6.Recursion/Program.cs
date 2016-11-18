using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Chapter6.Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "1";
            var word2 = "12";
            var word3 = "abcd";
            Rec.Anag.Show(word3);
        }
    }

    public class Rec
    {
        public static int Triangle(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return n + Triangle(n - 1);
        }

        public static int Fact(int n)
        {
            if (n == 0)
                return 1;
            return n*Fact(n-1);
        }

        public static class Anag
        {
            private static char[] _word;
            private static int _counter;
            private static int _size;

            public static void Show(string word)
            {
                _word = word.ToCharArray();
                _size = word.Length;
                Show(_word.Length);
            }

            private static void Shift(int newSize)
            {
                int i;
                var position = _size - newSize;
                var t = _word[position];
                for (i = position+1; i < _size; i++)
                {
                    _word[i - 1] = _word[i];
                }
                _word[i - 1] = t;
            }

            private static void Show(int newSize)
            {
                if (newSize == 1)
                    return;

                for (int i = 0; i < newSize; i++)
                {
                    Show(newSize - 1);
                    if (newSize == 2)
                        Print();
                    Shift(newSize);
                }
            }

            private static void Print()
            {
                Console.WriteLine("{0}.\t {1}", _counter++, new string(_word));
            }
        }
        
    }
}
