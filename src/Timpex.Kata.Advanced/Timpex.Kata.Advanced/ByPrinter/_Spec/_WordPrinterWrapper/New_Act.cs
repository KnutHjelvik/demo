using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._WordPrinterWrapper
{
    abstract class New_Act : Base_Act
    {
        protected WordPrinterWrapper<Word> Sut;
        protected Printer<Word> InnerPrinter = MockRepository.GenerateMock<WordPrinter>();
        protected Word TimpexWord = MockRepository.GenerateMock<TimpexWord>();
        
 
        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
           Sut = new WordPrinterWrapper<Word>(InnerPrinter); 
        }
    }


}