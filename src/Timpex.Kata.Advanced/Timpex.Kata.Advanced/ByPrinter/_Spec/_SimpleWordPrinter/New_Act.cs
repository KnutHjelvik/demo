using Rhino.Mocks;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._SimpleWordPrinter
{
    abstract class New_Act : Base_Act
    {
        protected SimpleWordPrinter Sut;
        protected WordConcatenating WordConcatenating = MockRepository.GenerateMock<WordConcatenating>();
        protected Word Word1 = MockRepository.GenerateMock<Word>();
        protected Word Word2 = MockRepository.GenerateMock<Word>();
        

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new SimpleWordPrinter(WordConcatenating);
        }
    }


}