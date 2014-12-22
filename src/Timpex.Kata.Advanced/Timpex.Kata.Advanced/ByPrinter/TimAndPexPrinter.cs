using System;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class TimAndPexPrinter
    {
        private WordPrinterWrapper<Word> _timPrinter;
        private Word _timpexWord = TimpexWord.New();
        public static Func<TimAndPexPrinter> New = () => new TimAndPexPrinter();

        public TimAndPexPrinter(Word word,WordPrinterWrapper<Word> timPrinter)
        {
            _timPrinter = timPrinter;
            _timpexWord = word;
        }

        public virtual string Print()
        {
            return _timPrinter.Print(_timpexWord);
        }

        public TimAndPexPrinter()
        {
        }


    }
}