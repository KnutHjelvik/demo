using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;
using Timpex.Kata.Advanced.ByPrinter;

namespace Timpex.Kata.Advanced
{
    public class Timpex
    {
        private TimpexPredicate _timpexPredicate = TimpexPredicate.New();
        private CounterPrinter _counterPrinter = CounterPrinter.New();
        private TimAndPexPrinter _timAndPexPrinter = TimAndPexPrinter.New();
        private Counter _counter;

        public Timpex(TimpexPredicate timpexPredicate,CounterPrinter counterPrinter,TimAndPexPrinter timAndPexPrinter)
        {

        }

        public string Print(Counter _counter)
        {
            throw new System.Exception();
        }


        public Timpex()
        {
        }
    }
}