using System;

namespace Timpex.Kata.ByAdvancedTimpexPrinter2
{
    public class NumberCounter : Counter
    {
        public int Count { set; get; }
        public virtual void IncrementNumber()
        {
            Count++;
        }

        public virtual int GetValue()
        {
            return Count;
        }
    }
}
