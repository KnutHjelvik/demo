using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class PexPrinter:Printer<PexWord>
    {
        private WordPrinterWrapper<PexWord> _pexPrinter = new WordPrinterWrapper<PexWord>();

        public PexPrinter(WordPrinterWrapper<PexWord> pexPrinter)
        {
            _pexPrinter = pexPrinter;
        }


        public string Print(PexWord word)
        {
            return _pexPrinter.Print(word);
        }

        public PexPrinter()
        {
        }
    }
}