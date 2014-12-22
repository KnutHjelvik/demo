using System;
using Rhino.Mocks;
using Timpex.Kata.Advanced.ByCounter;

namespace Timpex.Kata.Advanced.ByConverter._Spec._TextConverter.New
{
    abstract class Convert_Act : New_Act
    {
        protected Counter Counter = MockRepository.GenerateMock<Counter>();
        protected String Expected = "6";
        protected String Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(6);
        }

        protected override void Act()
        {
            Returned = Sut.Convert(Counter);
        }
    }


}