using Rhino.Mocks;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimAndPexPrinter
{
    abstract class New_Act : Base_Act
    {
        protected TimAndPexPrinter Sut;
        protected WordPrinterWrapper<Word> WordPrinterWrapper = MockRepository.GenerateMock<WordPrinterWrapper<Word>>();
        protected TimpexWord TimWord = MockRepository.GenerateMock<TimpexWord>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new TimAndPexPrinter(TimWord,WordPrinterWrapper);
        }
    }


}