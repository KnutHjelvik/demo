using Rhino.Mocks;
using Timpex.IO.ByReading;

namespace Timpex.Sscc.ByCode._Spec._ReadCodes
{
    abstract class New_Act : Base_Act
    {
        protected ReadCodesCore Sut;
        protected FileReader FileReader = MockRepository.GenerateMock<FileReader>();
        protected CodelistFactory CodelistFactory = MockRepository.GenerateMock<CodelistFactory>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new ReadCodesCore(FileReader,CodelistFactory);
        }
    }


}