using Rhino.Mocks;
using Timpex.Kata.Advanced.ByConverter;
using Timpex.Kata.Advanced.ByCounter;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._CounterPrinter
{
    abstract class New_Act : Base_Act
    {
        protected CounterPrinter Sut;
        protected TextConverter TextConverter = MockRepository.GenerateMock<TextConverter>();
        protected Counter Counter = MockRepository.GenerateMock<Counter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CounterPrinter(TextConverter);
        }
    }


}