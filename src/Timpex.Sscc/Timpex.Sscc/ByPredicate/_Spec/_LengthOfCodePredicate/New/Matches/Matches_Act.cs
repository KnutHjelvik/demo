using System;
using Rhino.Mocks;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByPredicate._Spec._LengthOfCodePredicate.New.Matches
{
    abstract class Matches_Act : New_Act
    {
        protected bool Expected = true;
        protected bool Returned;
        protected Code Code = MockRepository.GenerateMock<Code>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Code.Stub(x => x.value).Return(("(00)123456789123456789"));
        }

        protected override void Act()
        {
            Returned = Sut.Matches(Code);
        }
    }


}