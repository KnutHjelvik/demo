using Rhino.Mocks;
using Timpex.Sscc.ByPredicate;

namespace Timpex.Sscc.ByCode._Spec._CodeExcluder
{
    abstract class New_Act : Base_Act
    {
        protected CodeExcluder Sut;
        protected SSCCPredicate SsccPredicate = MockRepository.GenerateMock<SSCCPredicate>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CodeExcluder(SsccPredicate);
        }
    }


}