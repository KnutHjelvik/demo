using Rhino.Mocks;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced._Spec._AdvancedWordPrinter.New.ActualWord_AndCount
{
    abstract class Print_Act : New_Act
    {
        protected Word PexWord = new PexWord();
        protected string Returned;
        protected string Expected = "tim 3";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(3);
            TimpexPredicate.Stub(x => x.Matches(Counter)).Return(false);
            HandlerBase.Stub(x => x.HandleWordBasedOnCounter(Counter)).Return(PexWord);
            ActualWord.Stub(x => x.Value()).Return("tim");
            WordAndCountPrinter.Stub(x => x.Print(Counter, ActualWord)).Return("tim 3");
        }

        protected override void Act()
        {   
            Returned = Sut.Print(Counter, ActualWord);
        }
    }


}