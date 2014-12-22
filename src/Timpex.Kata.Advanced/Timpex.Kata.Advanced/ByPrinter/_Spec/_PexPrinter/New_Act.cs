using Rhino.Mocks;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._PexPrinter
{
    abstract class New_Act : Base_Act
    {
        protected PexPrinter Sut;
        protected WordPrinterWrapper<Word> WordPrinterWrapper = MockRepository.GenerateMock<WordPrinterWrapper<Word>>();
        protected PexWord PexWord = MockRepository.GenerateMock<PexWord>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new PexPrinter(PexWord,WordPrinterWrapper);
        }
    }


}