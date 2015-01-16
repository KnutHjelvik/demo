using Rhino.Mocks;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByPredicate._Spec._SSCCPredicate.New.Matches
{
    abstract class Matches_Act : New_Act
    {
        protected bool Expected = true;
        private Code Code = MockRepository.GenerateMock<Code>();
        protected bool Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            ApplicationIdentifierPredicate.Stub(x => x.Matches(Code)).Return(true);
            LengthOfCodePredicate.Stub(x => x.Matches(Code)).Return(true);

        }

        protected override void Act()
        {
            Returned = Sut.Matches(Code);
        }
    }


}