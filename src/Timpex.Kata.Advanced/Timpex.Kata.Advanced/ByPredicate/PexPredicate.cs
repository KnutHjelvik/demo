using System;
using Timpex.Kata.Advanced.ByCounter;

namespace Timpex.Kata.Advanced.ByPredicate
{
    public class PexPredicate:PredicateCore
    {
        public static Func<PexPredicate> New = () => new PexPredicate();

        public virtual bool Matches(Counter counter)
        {
            return counter.Count % 5 == 0;
        }

        public PexPredicate()
        {
        }
    }
}