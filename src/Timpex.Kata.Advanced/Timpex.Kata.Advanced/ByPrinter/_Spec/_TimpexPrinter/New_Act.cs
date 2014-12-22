using Rhino.Mocks;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter
{
    abstract class New_Act : Base_Act
    {
        protected TimpexPrinter Sut;
        protected WordPrinterWrapper<TimpexWord> WordPrinterWrapper = MockRepository.GenerateMock<WordPrinterWrapper<TimpexWord>>();
        protected TimpexWord TimWord = MockRepository.GenerateMock<TimpexWord>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new TimpexPrinter(WordPrinterWrapper);
        }
    }


}