using System;
using Rhino.Mocks;

namespace Timpex.Kata._Spec_Advanced._PexPrinter.New.PrintPexTimpex
{
    abstract class Print_Act : New_Act
    {


        protected String Returned;
        protected String Expected ="pex timpex";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.GetValue()).Return(15);
            CounterPredicate.Stub(x => x.IsDividableWithFive(Counter)).Return(true);
            CounterPredicate.Stub(x => x.IsDividableWithThree(Counter)).Return(true);
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
    }
}