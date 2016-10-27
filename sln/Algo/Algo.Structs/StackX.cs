using System;
using System.Linq;

namespace Algo.Structs
{
    public class StackX
    {
        private readonly int[] A;
        private int _current;

        public StackX(int size)
        {
            A = new int[size];
            _current = -1;
        }

        public void Push(int x)
        {
            A[++_current] = x;
        }

        public int Pop()
        {
            return A[_current--];
        }

        public int Peek()
        {
            return A[_current];
        }

        public void Print()
        {
            Console.WriteLine(string.Join(", ", A.Take(_current + 1)));
        }
    }
}