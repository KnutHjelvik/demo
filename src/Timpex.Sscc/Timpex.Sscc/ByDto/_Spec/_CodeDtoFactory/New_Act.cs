using Rhino.Mocks;

namespace Timpex.Sscc.ByDto._Spec._CodeDtoFactory
{
    abstract class New_Act : Base_Act
    {
        protected CodeDtoFactory Sut;
        protected CodeToDtoMapper CodeToDtoMapper = MockRepository.GenerateMock<CodeToDtoMapper>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CodeDtoFactory(CodeToDtoMapper);
        }
    }


}