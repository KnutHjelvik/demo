using System;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class TimPrinter
    {
      
        private WordPrinterWrapper<Word> _timPrinter = new WordPrinterWrapper<Word>();
        private Word _timWord = TimWord.New();
        public static Func<TimPrinter> New = () => new TimPrinter();

        public TimPrinter(Word word,WordPrinterWrapper<Word> timPrinter)
        {
            _timPrinter = timPrinter;
            _timWord = word;
        }

        public virtual string Print()
        {
            return _timPrinter.Print(_timWord);
        }

        public TimPrinter()
        {
        }


    }
}