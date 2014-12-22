using System;
using System.Runtime.InteropServices;

namespace Timpex.Kata.ByAdvancedTimpexPrinter2
{
    public class PexPrinter : Printer
    {
        private Counter _numberCounter = new NumberCounter();
        private CounterPredicate _counterPredicate = new CounterPredicate();
        private String _result;

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

        private bool TryPrintPexTimpex()
        {
            bool match = IsPexTimpex();
            if (match)
                _result = "pex timpex";
            return match;
        }

        private bool TryPrintPexTim()
        {
            bool match = IsPexTim();
            if (match)
                _result = "pex tim";
            return match;
        } 

        private bool IsPexTimpex()
        {
            return IsPexPex() && IsPexTim();
        }

        private bool IsPexTim()
        {
            return _counterPredicate.IsDividableWithThree(_numberCounter);
        }

        private bool IsPexPex()
        {
            return _counterPredicate.IsDividableWithFive(_numberCounter);
        }


        public PexPrinter(Counter numberCounter, CounterPredicate counterPredicate)
        {
            _numberCounter = numberCounter;
            _counterPredicate = counterPredicate;
        }
    }
}
    


