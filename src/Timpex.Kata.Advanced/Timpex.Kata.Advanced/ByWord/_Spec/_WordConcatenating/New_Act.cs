using Rhino.Mocks;
using Timpex.Kata.Advanced.ByPrinter;

namespace Timpex.Kata.Advanced.ByWord._Spec._WordConcatenating
{
    abstract class New_Act : Base_Act
    {
        protected WordConcatenating Sut;
        protected WordStringTrimmer WordStringTrimmer = MockRepository.GenerateMock<WordStringTrimmer>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new WordConcatenating();
        }
    }



}