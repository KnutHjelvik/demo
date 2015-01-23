using Rhino.Mocks;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByDto._Spec._CodeToDtoMapper
{
    abstract class New_Act : Base_Act
    {
        protected CodeToDtoMapper Sut;
        protected CodeExtracter CodeExtracter = MockRepository.GenerateMock<CodeExtracter>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CodeToDtoMapper(CodeExtracter);
        }
    }


}