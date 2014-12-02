using System;

namespace Timpex.Kata.ByAdvancedTimpexPrinter2
{
    public class TimPrinter: Printer
    {
        private Counter _numberCounter = new NumberCounter();
        private CounterPredicate _counterPredicate = new CounterPredicate();


        public TimPrinter()
        {

        }

        public virtual string Print()
        {
            _numberCounter.IncrementNumber();
            if(_numberCounter.GetValue()==1)
                return "tim";
            if (_counterPredicate.IsDividableWithFive(_numberCounter) &&
                _counterPredicate.IsDividableWithThree(_numberCounter))
                return "tim timpex";
            if (_counterPredicate.IsDividableWithThree(_numberCounter))
                return "tim tim";
            if (_counterPredicate.IsDividableWithFive(_numberCounter))
                return "tim pex";
            return "tim" + _numberCounter.GetValue().ToString();
        }

        public TimPrinter(Counter numberCounter,CounterPredicate counterPredicate)
        {
            _numberCounter = numberCounter;
            _counterPredicate = counterPredicate;
        }
    }
}
