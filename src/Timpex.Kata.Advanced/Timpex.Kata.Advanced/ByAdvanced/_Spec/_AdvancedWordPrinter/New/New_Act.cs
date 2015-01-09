using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;
using Timpex.Kata.Advanced.ByPrinter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced._Spec._AdvancedWordPrinter.New
{
    abstract class New_Act : Base_Act
    {
        protected AdvancedWordPrinter Sut;
        protected TimpexPredicate TimpexPredicate = MockRepository.GenerateMock<TimpexPredicate>();
        protected HandlerBase HandlerBase = MockRepository.GenerateMock<HandlerBase>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected Word ActualWord = MockRepository.GenerateMock<TimWord>();
        protected WordAndCountPrinter WordAndCountPrinter = MockRepository.GenerateMock<WordAndCountPrinter>();
        protected Word PexWord = new PexWord();
        protected SimpleWordPrinter SimpleWordPrinter = MockRepository.GenerateMock<SimpleWordPrinter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
      
        }

        protected override void Act()
        {
            Sut = new AdvancedWordPrinter(HandlerBase,TimpexPredicate,WordAndCountPrinter,SimpleWordPrinter);
        }
    }


}