using Rhino.Mocks;

namespace Timpex.Sscc.ByDto._Spec._DtoPresentator
{
    abstract class New_Act : Base_Act
    {
        protected DtoPresentator Sut;
        protected CodeDtoFactory CodeDtoFactory = MockRepository.GenerateMock<CodeDtoFactory>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new DtoPresentator(CodeDtoFactory);
        }
    }


}