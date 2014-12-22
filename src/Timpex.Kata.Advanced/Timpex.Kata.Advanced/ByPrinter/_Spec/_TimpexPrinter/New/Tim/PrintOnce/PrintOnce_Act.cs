using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter.New.Tim.PrintOnce
{
    abstract class PrintOnce_Act : New_Act
    {
        protected String Expected = "tim";
        protected String Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(5);
            TimPredicate.Stub(x => x.Matches(Counter)).Return(true);
            PexPredicate.Stub(x => x.Matches(Counter)).Return(false);
            TimPrinter.Stub(x => x.Print()).Return("tim");
        }

        protected override void Act()
        {

            Returned = Sut.Print(Counter);
        }
    }


}