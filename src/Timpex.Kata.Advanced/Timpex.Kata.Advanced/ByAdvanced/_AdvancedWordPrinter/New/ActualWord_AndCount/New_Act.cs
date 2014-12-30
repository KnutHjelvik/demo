using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;
using Timpex.Kata.Advanced.ByPrinter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced._AdvancedWordPrinter.New.ActualWord_AndCount
{
    abstract class New_Act : Base_Act
    {
        protected AdvancedWordPrinter Sut;
        protected TimpexPredicate TimpexPredicate = MockRepository.GenerateMock<TimpexPredicate>();
        protected HandleCounter HandleCounter = MockRepository.GenerateMock<HandleCounter>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected Word ActualWord = MockRepository.GenerateMock<TimWord>();
        protected WordAndCountPrinter WordAndCountPrinter = MockRepository.GenerateMock<WordAndCountPrinter>();
        protected Word PexWord = new PexWord();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(3);
            TimpexPredicate.Stub(x => x.Matches(Counter)).Return(false);
            HandleCounter.Stub(x => x.HandleWordBasedOnCounter(Counter)).Return(PexWord);
            ActualWord.Stub(x => x.Value()).Return("tim");
            WordAndCountPrinter.Stub(x => x.Print(Counter, ActualWord)).Return("tim 3");
        }

        protected override void Act()
        {
            Sut = new AdvancedWordPrinter(HandleCounter,TimpexPredicate,WordAndCountPrinter);
        }
    }


}