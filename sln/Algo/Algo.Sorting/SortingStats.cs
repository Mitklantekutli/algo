using System;

namespace Algo.Sorting
{
    public class SortingStats
    {
        private readonly DateTime _start;
        public SortingStats()
        {
            _start = DateTime.Now;
        }

        public int Copies { get; set; }
        public int Compares { get; set; }
        public TimeSpan Timespan { get; set; }

        public SortingStats Stop()
        {
            Timespan = DateTime.Now - _start;
            return this;
        }
    }
}