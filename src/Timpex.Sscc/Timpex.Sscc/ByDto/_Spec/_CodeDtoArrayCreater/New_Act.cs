using Rhino.Mocks;

namespace Timpex.Sscc.ByDto._Spec._CodeDtoArrayCreater
{
    abstract class New_Act : Base_Act
    {
        protected CodeDtoArrayCreater Sut;
        protected CodeDtoStringCreater CodeDtoStringCreater = MockRepository.GenerateMock<CodeDtoStringCreater>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CodeDtoArrayCreater(CodeDtoStringCreater);
        }
    }


}