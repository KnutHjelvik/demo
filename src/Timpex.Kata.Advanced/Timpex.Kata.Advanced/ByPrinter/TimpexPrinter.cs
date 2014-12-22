using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class TimpexPrinter
    {

        private readonly TimPrinter _timPrinter = TimPrinter.New();
        private readonly PredicateCore _timPredicate = TimPredicate.New();
        private readonly PexPrinter _pexPrinter = PexPrinter.New();
        private readonly PredicateCore _pexPredicate = PexPredicate.New();
        private readonly TimAndPexPrinter _timAndPexPrinter= TimAndPexPrinter.New();
        private string _result;
        private Counter _counter;


        public TimpexPrinter(PredicateCore pexPredicate, PexPrinter pexPrinter, TimAndPexPrinter timAndPexPrinter, PredicateCore timPredicate, TimPrinter timPrinter)
        {
            _pexPredicate = pexPredicate;
            _pexPrinter = pexPrinter;
            _timAndPexPrinter = timAndPexPrinter;
            _timPredicate = timPredicate;
            _timPrinter = timPrinter;
        }

        public virtual string Print(Counter counter)
        {
            _counter = counter;
            if (TryPrintTimPex() || TryPrintTim())
                return _result;
            return _pexPrinter.Print();

        }

        private bool TryPrintTim()
        {
            bool matching = IsTim();
            if (matching)
                _result = _timPrinter.Print();
            return matching;
        }

        private bool TryPrintTimPex()
        {
            bool matching = IsTimAndPex();
            if (matching)
                _result = _timAndPexPrinter.Print();
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
    }
}