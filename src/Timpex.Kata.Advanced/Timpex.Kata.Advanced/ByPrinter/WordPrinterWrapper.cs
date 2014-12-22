using System;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class WordPrinterWrapper<TWord> where TWord:Word
    {
        private Printer<Word> _innerPrinter = new WordPrinter();

        public WordPrinterWrapper(Printer<Word> innerPrinter)
        {
            _innerPrinter = innerPrinter;
        }

        public virtual string Print(TWord word)
        {
            return _innerPrinter.Print(word);
        }

        public WordPrinterWrapper()
        {
        }
    }
}