using System;

namespace Timpex.Sscc.ByPredicate._Spec._EmptyPredicate.New.Empty
{
    abstract class IsEmpty_Act : New_Act
    {
        protected bool Expected = true;
        protected bool Returned;
        private string line = String.Empty;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Sut.IsEmpty(line);
        }
    }


}