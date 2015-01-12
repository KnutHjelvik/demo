

using System;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;
using Timpex.Kata.Advanced.ByPrinter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced
{
    public class AdvancedWordPrinter
    {
        private HandlerBase _handlerBase = HandlerBase.New();
        private TimpexPredicate _timpexPredicate = TimpexPredicate.New();
        private WordAndCountPrinter _wordAndCountPrinter = WordAndCountPrinter.New();
        private SimpleWordPrinter _simpleWordPrinter = SimpleWordPrinter.New();
        private Word _resultWord;
        private Counter _counter;

        public static Func<AdvancedWordPrinter> New = () => new AdvancedWordPrinter();

        public AdvancedWordPrinter(HandlerBase handlerBase, TimpexPredicate timpexPredicate,WordAndCountPrinter wordAndCountPrinter,SimpleWordPrinter simpleWordPrinter)
        {
            _timpexPredicate = timpexPredicate;
            _handlerBase = handlerBase;
            _wordAndCountPrinter = wordAndCountPrinter;
        }

        public String Print(Counter counter,Word actualWord)
        {
            _counter = counter;
            if (IsTimOrPex())
                return _simpleWordPrinter.Print(actualWord, _resultWord);
            return _wordAndCountPrinter.Print(_counter, actualWord);
        }


        private bool IsTimOrPex()
        {
            bool matching = _timpexPredicate.Matches(_counter);
            if (matching)
                _resultWord = _handlerBase.HandleWordBasedOnCounter(_counter);
            return matching;
        }

        public AdvancedWordPrinter()
        {
        }
    }
}