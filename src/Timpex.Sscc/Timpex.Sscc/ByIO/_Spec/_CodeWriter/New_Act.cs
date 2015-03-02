using Rhino.Mocks;
using Timpex.Sscc.ByDto;

namespace Timpex.Sscc.ByIO._Spec._CodeWriter
{
    abstract class New_Act : Base_Act
    {
        protected CodeWriter Sut;
        protected CodeWriterCore CodeWriterCore = MockRepository.GenerateMock<CodeWriterCore>();
        protected CodeDtoArrayCreater CodeDtoArrayCreater = MockRepository.GenerateMock<CodeDtoArrayCreater>();


        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new CodeWriter(CodeDtoArrayCreater,CodeWriterCore);
        }
    }


}