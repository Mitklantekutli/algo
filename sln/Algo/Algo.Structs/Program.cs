using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Structs
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

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
