using System;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByAdvanced._Spec._PexWordFactory.New
{
    abstract class Create_Act : New_Act
    {
        protected Type Expected = PexWord.New().GetType();
        protected PexWord Returned;

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