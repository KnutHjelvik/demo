using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced._Spec._Timpex.New.PrintThird
{
    abstract class Print_Act : New_Act
    {
        protected String Expected = "tim";
        protected String Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(3);
            TimpexPredicate.Stub(x => x.Matches(Counter)).Return(true);
            TimpexPrinter.Stub(x => x.Print(Counter)).Return("tim");
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
    }


}