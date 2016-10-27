using System;
using System.Linq;

namespace Algo.Structs
{
    public class QueueX
    {
        private readonly int[] A;
        private int _rear;
        private int _front;

        public QueueX(int size)
        {
            A = new int[size];
            _front = _rear = -1;
        }

        public void Enqueue(int x)
        {
            A[++_front] = x;
            if (_rear == -1)
                _rear = _front;
        }

        public int Dequeue()
        {
            return A[_rear++];
        }

        public int Peek()
        {
            return A[_rear];
        }


        public void Print()
        {
            Console.WriteLine(string.Join(", ", A.Skip(_rear + 1).Take(_front - _rear + 1)));
        }
    }
}