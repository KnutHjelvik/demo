using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimpexPrinter.New.Pex.PrintTwice
{
    abstract class PrintTwice_Act : New_Act
    {
        protected String Expected = "pex 2";
        protected String Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(5);
            TimPredicate.Stub(x => x.Matches(Counter)).Return(false);
            PexPredicate.Stub(x => x.Matches(Counter)).Return(true);
            PexPrinter.Stub(x => x.Print()).Return("pex 2");
        }

        protected override void Act()
        {

            Returned = Sut.Print(Counter);
        }
    }


}