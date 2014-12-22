using System;
using Timpex.Kata.Advanced.ByCounter;

namespace Timpex.Kata.Advanced.ByPredicate
{
    public class TimPredicate:PredicateCore
    {
        public static Func<TimPredicate> New = () => new TimPredicate();
        
        public virtual bool Matches(Counter counter)
        {
            return counter.Count%3 == 0;
        }

        public TimPredicate()
        {
        }
    }
}