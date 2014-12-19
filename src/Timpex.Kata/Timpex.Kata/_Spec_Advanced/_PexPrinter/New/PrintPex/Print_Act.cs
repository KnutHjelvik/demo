using System;
using Rhino.Mocks;

namespace Timpex.Kata._Spec_Advanced._PexPrinter.New.PrintPex
{
    abstract class Print_Act : New_Act
    {


        protected String Returned;
        protected String Expected ="pex";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.GetValue()).Return(1);
            CounterPredicate.Stub(x => x.IsDividableWithFive(Counter)).Return(true);
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
    }
}