using System;
using Rhino.Mocks;

namespace Timpex.Kata._Spec_Advanced._PexPrinter.New.PrintPexCount
{
    abstract class Print_Act : New_Act
    {


        protected String Returned;
        protected String Expected ="pex 17";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.GetValue()).Return(17);
            CounterPredicate.Stub(x => x.IsDividableWithFive(Counter)).Return(false);
            CounterPredicate.Stub(x => x.IsDividableWithThree(Counter)).Return(false);
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
    }
}