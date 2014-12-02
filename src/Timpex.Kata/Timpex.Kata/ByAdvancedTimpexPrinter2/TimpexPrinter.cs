using System;

namespace Timpex.Kata.ByAdvancedTimpexPrinter2
{
    public class TimpexPrinter:Printer
    {
        private Counter _numberCounter = new NumberCounter();
        private CounterPredicate _counterPredicate = new CounterPredicate();

        public TimpexPrinter()
        {
            
        }

        public virtual string Print()
        {
            _numberCounter.IncrementNumber();
            if(_numberCounter.GetValue() ==1)
                return "timpex";
            if (_counterPredicate.IsDividableWithThree(_numberCounter) && _counterPredicate.IsDividableWithFive(_numberCounter))
                return "timpex timpex";
            if (_counterPredicate.IsDividableWithThree(_numberCounter))
                return "timpex tim";
            if (_counterPredicate.IsDividableWithFive(_numberCounter))
                return "timpex pex";
            return "timpex" + _numberCounter.GetValue().ToString();
        }

        public TimpexPrinter(Counter numberCounter,CounterPredicate counterPredicate)
        {
            _numberCounter = numberCounter;
            _counterPredicate = counterPredicate;
        }
    }
}
