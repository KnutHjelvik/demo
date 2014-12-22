using System;
using Timpex.Kata.Advanced.ByCounter;

namespace Timpex.Kata.Advanced.ByPredicate
{
    public class TimpexPredicate:PredicateCore
    {
        private readonly PredicateCore _timPredicate = TimPredicate.New();
        private readonly PredicateCore _pexPredicate = PexPredicate.New();
        public static Func<TimpexPredicate> New = () => new TimpexPredicate();
        
        public TimpexPredicate(PredicateCore timPredicate, PredicateCore pexPredicate)
        {
            _timPredicate = timPredicate;
            _pexPredicate = pexPredicate;
        }

        public virtual bool Matches(Counter counter)
        {
            return _timPredicate.Matches(counter) && _pexPredicate.Matches(counter);
        }

        public TimpexPredicate()
        {
        }
    }
}