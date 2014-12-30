using System;
using Rhino.Mocks;
using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByFactory._Spec._WordFactory.New
{
    abstract class Create_Act : New_Act
    {
        protected Type Expected = TimWord.New().GetType();
        protected TimWord Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Factory.Stub(x => x.Create()).Return(new TimWord());
        }

        protected override void Act()
        {
            Returned = Sut.Create();
        }
    }


}