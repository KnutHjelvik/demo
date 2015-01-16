using Rhino.Mocks;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByPredicate._Spec._SSCCPredicate.New.NotMatches
{
    abstract class Matches_Act : New_Act
    {
        protected bool Expected = false;
        private Code Code = MockRepository.GenerateMock<Code>();
        protected bool Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            ApplicationIdentifierPredicate.Stub(x => x.Matches(Code)).Return(false);
            LengthOfCodePredicate.Stub(x => x.Matches(Code)).Return(true);

        }

        protected override void Act()
        {
            Returned = Sut.Matches(Code);
        }
    }


}