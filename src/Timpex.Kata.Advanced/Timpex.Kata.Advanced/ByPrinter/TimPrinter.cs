using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class TimPrinter:Printer<TimWord>
    {
        private WordPrinterWrapper<TimWord> _timPrinter;

        public TimPrinter(WordPrinterWrapper<TimWord> timPrinter)
        {
            _timPrinter = timPrinter;
        }

        public virtual string Print(TimWord word)
        {
            return _timPrinter.Print(word);
        }

        public TimPrinter()
        {
        }


    }
}