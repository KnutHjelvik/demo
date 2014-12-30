

using System;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;
using Timpex.Kata.Advanced.ByPrinter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced
{
    public class AdvancedWordPrinter
    {
        private HandleCounter _handleCounter = HandleCounter.New();
        private TimpexPredicate _timpexPredicate = TimpexPredicate.New();
        private WordAndCountPrinter _wordAndCountPrinter = WordAndCountPrinter.New();
        
        private Word _resultWord;
        private Counter _counter;

        public static Func<AdvancedWordPrinter> New = () => new AdvancedWordPrinter();

        public AdvancedWordPrinter(HandleCounter handleCounter, TimpexPredicate timpexPredicate,WordAndCountPrinter wordAndCountPrinter)
        {
            _timpexPredicate = timpexPredicate;
            _handleCounter = handleCounter;
            _wordAndCountPrinter = wordAndCountPrinter;
        }

        public String Print(Counter counter,Word actualWord)
        {
            _counter = counter;
            if (IsTimOrPex())
                return actualWord.Value() + " " + _resultWord.Value();
            return _wordAndCountPrinter.Print(_counter, actualWord);
        }


        private bool IsTimOrPex()
        {
            bool matching = _timpexPredicate.Matches(_counter);
            if (matching)
                _resultWord = _handleCounter.HandleWordBasedOnCounter(_counter);
            return matching;
        }

        public AdvancedWordPrinter()
        {
        }
    }
}