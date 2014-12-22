using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._PexPrinter.New
{
    abstract class Print_Act : New_Act
    {
        protected String Expected = "pex";
        protected String Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            WordPrinterWrapper.Stub(x => x.Print(PexWord)).Return("pex");
        }

        protected override void Act()
        {
            Returned = Sut.Print();
        }
    }


}