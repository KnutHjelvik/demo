using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter
{
    public class WordPrinter:Printer<Word>
    {
        private Counter _counter = new Counter();

        public WordPrinter(Counter counter)
        {
            _counter = counter;
        }

        public virtual string Print(Word word)
        {
            _counter.IncrementCount();
            if (_counter.Count > 1)
                return word.Value() + " " + _counter.Count;
            return word.Value();

        }

        public WordPrinter()
        {

        }
    }
}