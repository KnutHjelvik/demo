using System;
using Rhino.Mocks;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced._Spec._TimpexWordFactory.New
{
    abstract class Create_Act : New_Act
    {
        protected Type Expected = TimpexWord.New().GetType();
        protected TimpexWord Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.Create();
        }
    }


}