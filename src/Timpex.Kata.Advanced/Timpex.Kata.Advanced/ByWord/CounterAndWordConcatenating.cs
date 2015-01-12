using System;
using Timpex.Kata.Advanced.ByConverter;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class CounterAndWordConcatenating
    {
        private TextConverter _textConverter = TextConverter.New();

        public static Func<CounterAndWordConcatenating> New = () => new CounterAndWordConcatenating();

        public CounterAndWordConcatenating(TextConverter textConverter)
        {
            _textConverter = textConverter;
        }

        public virtual string Concatinate(Counter counter, Word word)
        {
            var convertedValue = _textConverter.Convert(counter);
            var wordValue = word.Value();
            return wordValue + " " + convertedValue;
        }

        public CounterAndWordConcatenating()
        {
        }
    }
}