using System;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class SimpleWordPrinter
    {
        private WordConcatenating _wordConcatenating = WordConcatenating.New();

        public static Func<SimpleWordPrinter> New = () => new SimpleWordPrinter();

        public SimpleWordPrinter(WordConcatenating wordConcatenating)
        {
            _wordConcatenating = wordConcatenating;
        }

        public virtual String Print(Word firstWord,Word secondWord)
        {
            return _wordConcatenating.Concatinate(firstWord,secondWord);
        }

        public SimpleWordPrinter()
        {
        }
    }
}