using Rhino.Mocks;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByPredicate._Spec._LengthOfCodePredicate.New.NotMatches
{
    abstract class Matches_Act : New_Act
    {
        protected bool Expected = false;
        protected bool Returned;
        protected Code Code = MockRepository.GenerateMock<Code>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Code.Stub(x => x.value).Return("(00)");
        }

        protected override void Act()
        {
            Returned = Sut.Matches(Code);
        }
    }


}