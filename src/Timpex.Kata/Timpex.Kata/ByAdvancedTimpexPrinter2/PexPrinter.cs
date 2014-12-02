using System;

namespace Timpex.Kata.ByAdvancedTimpexPrinter2
{
    public class PexPrinter : Printer
    {
        private Counter _numberCounter = new NumberCounter();
        private CounterPredicate _counterPredicate = new CounterPredicate();


        public PexPrinter()
        {

        }

        public virtual string Print()
        {
            _numberCounter.IncrementNumber();
            if (_numberCounter.GetValue() == 1)
                return "pex";
            if (_counterPredicate.IsDividableWithFive(_numberCounter) &&
                _counterPredicate.IsDividableWithThree(_numberCounter))
                return "pex timpex";
            if (_counterPredicate.IsDividableWithThree(_numberCounter))
                return "pex tim";
            if (_counterPredicate.IsDividableWithFive(_numberCounter))
                return "pex pex";
            return "pex" + _numberCounter.GetValue().ToString();
        }

        public PexPrinter(Counter numberCounter, CounterPredicate counterPredicate)
        {
            _numberCounter = numberCounter;
            _counterPredicate = counterPredicate;
        }
    }
}
    


