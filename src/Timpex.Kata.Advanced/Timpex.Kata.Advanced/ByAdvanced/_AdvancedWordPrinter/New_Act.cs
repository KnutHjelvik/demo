using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPredicate;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced._AdvancedWordPrinter
{
    abstract class New_Act : Base_Act
    {
        protected AdvancedWordPrinter Sut;
        protected TimpexPredicate TimpexPredicate = MockRepository.GenerateMock<TimpexPredicate>();
        protected HandleCounter HandleCounter = MockRepository.GenerateMock<HandleCounter>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected Word ActualWord = MockRepository.GenerateMock<TimWord>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new AdvancedWordPrinter(HandleCounter,TimpexPredicate);
        }
    }


}