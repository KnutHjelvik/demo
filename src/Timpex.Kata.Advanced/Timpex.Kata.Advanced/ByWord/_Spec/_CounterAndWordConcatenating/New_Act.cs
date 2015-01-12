using Rhino.Mocks;
using Timpex.Kata.Advanced.ByConverter;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByPrinter;

namespace Timpex.Kata.Advanced.ByWord._Spec._CounterAndWordConcatenating
{
    abstract class New_Act : Base_Act
    {
        protected CounterAndWordConcatenating Sut;
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected Word Word = MockRepository.GenerateMock<TimWord>();
        protected TextConverter TextConverter = MockRepository.GenerateMock<TextConverter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            TextConverter.Stub(x => x.Convert(Counter)).Return("3");
        }

        protected override void Act()
        {
            Sut = new CounterAndWordConcatenating(TextConverter);
        }
    }


}