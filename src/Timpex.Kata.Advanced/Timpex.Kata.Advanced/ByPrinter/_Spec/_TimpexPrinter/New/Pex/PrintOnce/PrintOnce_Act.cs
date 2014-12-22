using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter.New.Pex.PrintOnce
{
    abstract class PrintOnce_Act : New_Act
    {
        protected String Expected = "pex";
        protected String Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(5);
            TimPredicate.Stub(x => x.Matches(Counter)).Return(false);
            PexPredicate.Stub(x => x.Matches(Counter)).Return(true);
            PexPrinter.Stub(x => x.Print()).Return("pex");
        }

        protected override void Act()
        {

            Returned = Sut.Print(Counter);
        }
    }


}