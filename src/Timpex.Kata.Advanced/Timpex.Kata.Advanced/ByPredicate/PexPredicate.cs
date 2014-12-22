using Timpex.Kata.Advanced.ByCounter;

namespace Timpex.Kata.Advanced.ByPredicate
{
    public class PexPredicate:PredicateCore
    {
        public bool Matches(Counter counter)
        {
            return counter.Count % 5 == 0;
        }
    }
}