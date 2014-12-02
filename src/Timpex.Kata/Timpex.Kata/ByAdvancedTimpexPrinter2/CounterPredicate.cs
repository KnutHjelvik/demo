using System;

namespace Timpex.Kata.ByAdvancedTimpexPrinter2
{
    public class CounterPredicate
    {
        public virtual Boolean IsDividableWithThree(Counter numberCounter)
        {
            int value = numberCounter.GetValue();
            return value % 3 == 0;
        }
        
        public virtual Boolean IsDividableWithFive(Counter numberCounter)
        {
            int value = numberCounter.GetValue();
            return value % 5 == 0;
        }


    }
}
