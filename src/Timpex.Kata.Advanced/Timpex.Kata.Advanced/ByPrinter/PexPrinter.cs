using System;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class PexPrinter
    {
        private WordPrinterWrapper<Word> _timPrinter = new WordPrinterWrapper<Word>();
        private Word _pexWord = PexWord.New();

        public static Func<PexPrinter> New = () => new PexPrinter();

        public PexPrinter(Word word,WordPrinterWrapper<Word> timPrinter)
        {
            _timPrinter = timPrinter;
            _pexWord = word;
        }

        public virtual string Print()
        {
            return _timPrinter.Print(_pexWord);
        }

        public PexPrinter()
        {
        }
    }
}