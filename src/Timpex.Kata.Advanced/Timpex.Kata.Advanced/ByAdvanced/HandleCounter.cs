using System;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced
{
    public class HandleCounter
    {
        private Counter _counter;
        private Word _resultWord;
        private TimPredicate _timPredicate = TimPredicate.New();
        private PexPredicate _pexPredicate = PexPredicate.New();
        public static Func<HandleCounter> New = () => new HandleCounter();

        public HandleCounter(TimPredicate timpexPredicate, PexPredicate pexPredicate)
        {
            _timPredicate = timpexPredicate;
            _pexPredicate = pexPredicate;
        }

       public virtual Word HandleWordBasedOnCounter(Counter counter)
        {
           _counter = counter;
           if (TryHandleTimPex() || TryHandleTim())
               return _resultWord;
           return PexWord.New();
        }

        private bool TryHandleTim()
        {
            bool matching = IsTim();
            if (matching)
                _resultWord = TimWord.New();
            return matching;
        }

        private bool TryHandleTimPex()
        {
            bool matching = IsTimAndPex();
            if (matching)
                _resultWord = TimpexWord.New();
            return matching;
        }

        private bool IsTim()
        {
            return _timPredicate.Matches(_counter);
        }

        private bool IsPex()
        {
            return _pexPredicate.Matches(_counter);
        }

        private bool IsTimAndPex()
        {
            return IsTim() && IsPex();
        }

        public HandleCounter()
        {
        }
    }
}