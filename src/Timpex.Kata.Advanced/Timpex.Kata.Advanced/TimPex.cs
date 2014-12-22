using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;
using Timpex.Kata.Advanced.ByPrinter;

namespace Timpex.Kata.Advanced
{
    public class Timpex
    {
        private TimpexPredicate _timpexPredicate = TimpexPredicate.New();
        private CounterPrinter _counterPrinter = CounterPrinter.New();
        private TimpexPrinter _timpexPrinter = TimpexPrinter.New();
        private Counter _counter = new Counter();

        public Timpex(TimpexPredicate timpexPredicate, CounterPrinter counterPrinter, TimpexPrinter timpexPrinter, Counter counter)
        {
            _timpexPredicate = timpexPredicate;
            _counterPrinter = counterPrinter;
            _timpexPrinter = timpexPrinter;
            _counter = counter;
        }

        public string Print()
        {
            _counter.IncrementCount();
            if (IsTimpex())
                return _timpexPrinter.Print(_counter);
            return _counterPrinter.Print(_counter);
        }

        private bool IsTimpex()
        {
            return _timpexPredicate.Matches(_counter);
        }


        public Timpex()
        {
        }
    }
}