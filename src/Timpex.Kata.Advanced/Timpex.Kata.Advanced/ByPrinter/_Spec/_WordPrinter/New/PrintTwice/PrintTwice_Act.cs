using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._WordPrinter.New.PrintTwice
{
    abstract class PrintTwice_Act : New_Act
    {
        protected String Expected = "timpex 2";
        protected String Returned;
        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(2);
            TimpexWord.Stub(x => x.Value()).Return("timpex");
        }

        protected override void Act()
        {
            Returned = Sut.Print(TimpexWord);
        }
    }


}