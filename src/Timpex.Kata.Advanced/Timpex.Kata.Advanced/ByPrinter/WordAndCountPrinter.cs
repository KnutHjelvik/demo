using System;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class WordAndCountPrinter
    {
        private WordConcatenating _wordConcatenating = WordConcatenating.New();

        public static Func<WordAndCountPrinter> New = () => new WordAndCountPrinter();

        public WordAndCountPrinter(WordConcatenating wordConcatenating)
        {
            _wordConcatenating = wordConcatenating;
        }

        public virtual string Print(Counter counter, Word word)
        {
            return _wordConcatenating.Concatinate(counter,word);
        }

        public WordAndCountPrinter()
        {
        }
    }
}