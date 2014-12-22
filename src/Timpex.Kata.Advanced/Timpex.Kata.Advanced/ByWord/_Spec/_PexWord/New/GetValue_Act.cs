using System;

namespace Timpex.Kata.Advanced.ByWord._Spec._PexWord.New
{
    abstract class GetValue_Act : New_Act
    {
        protected String Result;
        protected String Expected = "pex";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Result = Sut.Value();
        }
    }


}