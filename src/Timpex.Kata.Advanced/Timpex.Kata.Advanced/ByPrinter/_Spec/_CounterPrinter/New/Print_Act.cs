using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._CounterPrinter.New
{
    abstract class Print_Act : New_Act
    {
        protected String Expected = "2";
        protected String Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(2);
            TextConverter.Stub(x => x.Convert(Counter)).Return("2");

        }

        protected override void Act()
        {
            Returned = Sut.Print(Counter);
        }
    }


}