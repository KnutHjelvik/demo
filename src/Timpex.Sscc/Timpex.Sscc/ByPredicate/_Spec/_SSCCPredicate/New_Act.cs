using Rhino.Mocks;

namespace Timpex.Sscc.ByPredicate._Spec._SSCCPredicate
{
    abstract class New_Act: Base_Act
    {
        protected SSCCPredicate Sut;
        protected LengthOfCodePredicate LengthOfCodePredicate = MockRepository.GenerateMock<LengthOfCodePredicate>();
        protected ApplicationIdentifierPredicate ApplicationIdentifierPredicate = MockRepository.GenerateMock<ApplicationIdentifierPredicate>(); 

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new SSCCPredicate(ApplicationIdentifierPredicate,LengthOfCodePredicate);
        }
    }


}