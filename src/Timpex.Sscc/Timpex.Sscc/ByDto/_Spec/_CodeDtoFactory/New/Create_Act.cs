using Rhino.Mocks;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByDto._Spec._CodeDtoFactory.New
{
    abstract class Create_Act : New_Act
    {
        protected Code UnhandledCode = MockRepository.GenerateMock<Code>();
        protected CodeDto Expected = MockRepository.GenerateMock<CodeDto>();
        protected CodeDto Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            CodeToDtoMapper.Stub(x => x.Map(UnhandledCode)).Return(Expected);
        }

        

        protected override void Act()
        {
            Returned = Sut.Create(UnhandledCode);
        }
    }


}