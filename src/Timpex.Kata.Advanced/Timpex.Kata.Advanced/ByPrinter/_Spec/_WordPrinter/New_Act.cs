using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._WordPrinter
{
    abstract class New_Act : Base_Act
    {
        protected Printer<Word> Sut;
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected Word TimpexWord = MockRepository.GenerateMock<TimpexWord>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new WordPrinter(Counter);
        }
    }


}