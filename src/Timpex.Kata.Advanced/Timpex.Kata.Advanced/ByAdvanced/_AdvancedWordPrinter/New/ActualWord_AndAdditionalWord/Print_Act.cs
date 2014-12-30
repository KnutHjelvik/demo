using Rhino.Mocks;
using Timpex.Kata.Advanced.ByAdvanced._AdvancedWordPrinter.New.ActualWord_AndCount;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced._AdvancedWordPrinter.New.ActualWord_AndAdditionalWord
{
    abstract class Print_Act : New_Act
    {
        protected string Returned;
        protected string Expected = "tim pex";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {   
            Returned = Sut.Print(Counter, ActualWord);
        }
    }


}