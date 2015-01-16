using Rhino.Mocks;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByPredicate._Spec._ApplicationIdentifierPredicate.New.NoMatch
{
    abstract class Matches_Act : New_Act
    {
        protected Code Code = MockRepository.GenerateMock<Code>();
        protected bool Expected = false;
        protected bool Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Code.Stub(x => x.value).Return("00");
        }

        protected override void Act()
        {
            Returned = Sut.Matches(Code);
        }
    }


}