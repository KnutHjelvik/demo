using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByAdvanced._Spec._AdvancedWordPrinter.New.ActualWord_AndAdditionalWord
{
    abstract class Print_Act : New_Act
    {
        protected string Returned;
        protected string Expected = "tim pex";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(3);
            TimpexPredicate.Stub(x => x.Matches(Counter)).Return(true);
            HandlerBase.Stub(x => x.HandleWordBasedOnCounter(Counter)).Return(PexWord);
            ActualWord.Stub(x => x.Value()).Return("tim");
            WordAndCountPrinter.Stub(x => x.Print(Counter, ActualWord)).Return("tim 3");
            SimpleWordPrinter.Stub(x => x.Print(ActualWord, PexWord)).Return(Expected);
        }

        protected override void Act()
        {   
            Returned = Sut.Print(Counter, ActualWord);
        }
    }


}