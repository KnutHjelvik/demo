using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._TimAndPexPrinter.New
{
    abstract class Print_Act : New_Act
    {
        protected String Expected = "timpex";
        protected String Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            WordPrinterWrapper.Stub(x => x.Print(TimWord)).Return("timpex");
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
    }


}