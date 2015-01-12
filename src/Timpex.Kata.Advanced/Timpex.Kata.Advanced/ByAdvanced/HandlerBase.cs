using System;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced
{
    public class HandlerBase
    {
        private Counter _counter;
        private Word _resultWord;
        private TimPredicate _timPredicate = TimPredicate.New();
        private PexPredicate _pexPredicate = PexPredicate.New();
        private TimWordFactory _timWordFactory = TimWordFactory.New();
        private PexWordFactory _pexWordFactory = PexWordFactory.New();
        private TimpexWordFactory _timpexWordFactory = TimpexWordFactory.New();
        public static Func<HandlerBase> New = () => new HandlerBase();


        public HandlerBase(TimPredicate timpexPredicate, PexPredicate pexPredicate, TimpexWordFactory timpexWordFactory,PexWordFactory pexWordFactory, TimWordFactory timWordFactory)
        {
            _timPredicate = timpexPredicate;
            _pexPredicate = pexPredicate;
            _timpexWordFactory = timpexWordFactory;
            _pexWordFactory = pexWordFactory;
            _timWordFactory = timWordFactory;
        }

       public virtual Word HandleWordBasedOnCounter(Counter counter)
        {
           _counter = counter;
           if (TryHandleTimPex() || TryHandleTim())
               return _resultWord;
           return _pexWordFactory.Create();
        }

        private bool TryHandleTim()
        {
            bool matching = IsTim();
            if (matching)
                _resultWord = _timWordFactory.Create();
            return matching;
        }

        private bool TryHandleTimPex()
        {
            bool matching = IsTimAndPex();
            if (matching)
                _resultWord = _timpexWordFactory.Create();
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

        public HandlerBase()
        {
        }

      
    }
}