using System;
using Timpex.Kata.Advanced.ByConverter;
using Timpex.Kata.Advanced.ByCounter;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class CounterPrinter
    {
        private TextConverter _textConverter;
        public static Func<CounterPrinter> New = () => new CounterPrinterCo();

        public CounterPrinter(TextConverter converter)
        {
            _textConverter = converter;
        }

        public virtual string Print(Counter counter)
        {
            var value = _textConverter.Convert(counter);
            return value;
        }

        public CounterPrinter()
        {
        }
    }
}