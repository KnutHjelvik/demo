using System;
using Rhino.Mocks;

namespace Timpex.Kata._Spec_Advanced._PexPrinter.New.PrintPexTim
{
    abstract class Print_Act : New_Act
    {


        protected String Returned;
        protected String Expected ="pex tim";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.GetValue()).Return(15);
            CounterPredicate.Stub(x => x.IsDividableWithThree(Counter)).Return(true);
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
    }
}