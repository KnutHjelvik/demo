using System;
using Timpex.Kata.ByAdvancedTimpexPrinter2;

namespace Timpex.Kata
{
    public class AdvancedTimpexPrinterTwo : Printer
    {
        private readonly Printer _timpexPrinter = new TimpexPrinter();
        private readonly Printer _timPrinter = new TimPrinter();
        private readonly Printer _pexPrinter= new PexPrinter();
        private readonly CounterPredicate _counterPredicate = new CounterPredicate();
        private readonly Counter _numberCounter = new NumberCounter();


        public String Print()
        {
            _numberCounter.IncrementNumber();
            if (_counterPredicate.IsDividableWithFive(_numberCounter) && _counterPredicate.IsDividableWithThree(_numberCounter))
                return _timpexPrinter.Print();
            if (_counterPredicate.IsDividableWithFive(_numberCounter))
                    return _pexPrinter.Print();
            if (_counterPredicate.IsDividableWithThree(_numberCounter))
                return _timPrinter.Print();
            return _numberCounter.GetValue().ToString();
        }

        public AdvancedTimpexPrinterTwo(Printer timpexPrinter, Printer timPrinter, Printer pexPrinter, CounterPredicate counterPredicate, Counter numberCounter)
        {
            _timpexPrinter = timpexPrinter;
            _timPrinter = timPrinter;
            _pexPrinter = pexPrinter;
            _counterPredicate = counterPredicate;
            _numberCounter = numberCounter;
        }


    }
}
