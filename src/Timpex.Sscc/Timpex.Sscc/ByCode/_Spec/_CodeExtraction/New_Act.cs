using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._CodeExtraction
{
    abstract class New_Act : Base_Act
    {
        protected CodeExtracter Sut;
        protected Code Code = MockRepository.GenerateMock<Code>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CodeExtracter();
            Sut.Setup(Code);
        }
    }


}