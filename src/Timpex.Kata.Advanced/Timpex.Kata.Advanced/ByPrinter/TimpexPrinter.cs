using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class TimpexPrinter : Printer<TimpexWord>
    {
        private WordPrinterWrapper<TimpexWord> _timpexPrinter;

        public TimpexPrinter(WordPrinterWrapper<TimpexWord> timPrinter)
        {
            _timpexPrinter = timPrinter;
        }

        public virtual string Print(TimpexWord word)
        {
            return _timpexPrinter.Print(word);
        }

        public TimpexPrinter()
        {
        }


    }
}