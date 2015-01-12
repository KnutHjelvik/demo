using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._WordAndCountPrinter
{
    abstract class New_Act : Base_Act
    {
        protected WordAndCountPrinter Sut;
        protected CounterAndWordConcatenating CounterAndWordConcatenating = MockRepository.GenerateMock<CounterAndWordConcatenating>();
        protected Word Word = MockRepository.GenerateMock<Word>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(2);
            Word.Stub(x => x.Value()).Return("tim");
            CounterAndWordConcatenating.Stub(x => x.Concatinate(Counter, Word)).Return("tim 2");
        }

        protected override void Act()
        {
            Sut = new WordAndCountPrinter(CounterAndWordConcatenating);
        }
    }


}