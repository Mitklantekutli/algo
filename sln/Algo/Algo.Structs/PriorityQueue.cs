using System;
using System.Linq;

namespace Algo.Structs
{
    public class PriorityQueue
    {
        private readonly int[] A;
        private int _rear;
        private int _front;

        public PriorityQueue(int size)
        {
            A = new int[size];
            _rear = _front = -1;
        }

        public void Enqueue(int x)
        {
            _front++;
            if (_rear == -1)
                _rear = _front;
            var place = 0;
            for (int i = _rear; i <= _front; i++)
            {
                if (A[i] < x)
                {
                    place = i;
                    break;
                }
            }
            if(_front>_rear)
                for (int i = _front; i > place ; i--)
                {
                    A[i] = A[i-1];
                }
            A[place] = x;
            
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