
using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._WordPrinterWrapper.New
{
    abstract class Print_Act : New_Act
    {
        private String _value = "timpex";
        protected String Expected = "timpex";
        protected String Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            TimpexWord.Stub(x => x.Value()).Return(_value);
            InnerPrinter.Stub(x => x.Print(TimpexWord)).Return(_value);
        }

        protected override void Act()
        {
            Returned = Sut.Print(TimpexWord);
        }
    }


}