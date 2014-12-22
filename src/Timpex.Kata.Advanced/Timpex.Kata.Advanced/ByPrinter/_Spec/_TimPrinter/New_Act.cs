using Rhino.Mocks;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimPrinter
{
    abstract class New_Act : Base_Act
    {
        protected TimPrinter Sut;
        protected WordPrinterWrapper<TimWord> WordPrinterWrapper = MockRepository.GenerateMock<WordPrinterWrapper<TimWord>>();
        protected TimWord TimWord = MockRepository.GenerateMock<TimWord>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new TimPrinter(WordPrinterWrapper);
        }
    }


}