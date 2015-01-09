using System;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class WordAndCountPrinter
    {
        private CounterAndWordConcatenating _counterAndWordConcatenating = CounterAndWordConcatenating.New();

        public static Func<WordAndCountPrinter> New = () => new WordAndCountPrinter();

        public WordAndCountPrinter(CounterAndWordConcatenating counterAndWordConcatenating)
        {
            _counterAndWordConcatenating = counterAndWordConcatenating;
        }

        public virtual string Print(Counter counter, Word word)
        {
            return _counterAndWordConcatenating.Concatinate(counter,word);
        }

        public WordAndCountPrinter()
        {
        }
    }
}