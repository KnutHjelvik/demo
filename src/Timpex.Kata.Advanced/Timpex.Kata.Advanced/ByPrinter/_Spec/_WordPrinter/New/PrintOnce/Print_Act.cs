using System;
using Rhino.Mocks;

namespace Timpex.Kata.Advanced.ByPrinter._Spec._WordPrinter.New.PrintOnce
{
    abstract class Print_Act : New_Act
    {
        protected String Expected = "timpex";
        protected String Returned;
        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Counter.Stub(x => x.Count).Return(1);
            TimpexWord.Stub(x => x.Value()).Return("timpex");
        }

        protected override void Act()
        {
            Returned = Sut.Print(TimpexWord);
        }
    }


}