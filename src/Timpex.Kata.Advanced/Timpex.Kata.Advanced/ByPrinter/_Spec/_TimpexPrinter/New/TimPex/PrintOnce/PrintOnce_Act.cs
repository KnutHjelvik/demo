using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter.New.TimPex.PrintOnce
{
    abstract class PrintOnce_Act : New_Act
    {
        protected String Expected = "timpex";
        protected String Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(5);
            TimPredicate.Stub(x => x.Matches(Counter)).Return(true);
            PexPredicate.Stub(x => x.Matches(Counter)).Return(true);
            TimAndPexPrinter.Stub(x => x.Print()).Return("timpex");
        }

        protected override void Act()
        {

            Returned = Sut.Print(Counter);
        }
    }


}