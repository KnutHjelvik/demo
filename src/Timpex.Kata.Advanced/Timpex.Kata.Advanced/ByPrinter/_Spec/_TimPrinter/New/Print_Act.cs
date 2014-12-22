using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimPrinter.New
{
    abstract class Print_Act : New_Act
    {
        protected String Expected = "tim";
        protected String Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            WordPrinterWrapper.Stub(x => x.Print(TimWord)).Return("tim");
        }

        protected override void Act()
        {
            Returned = Sut.Print(TimWord);
        }
    }


}