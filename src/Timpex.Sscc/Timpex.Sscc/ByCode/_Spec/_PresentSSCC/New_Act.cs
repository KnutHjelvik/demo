using Rhino.Mocks;
using Timpex.Sscc.ByDto;

namespace Timpex.Sscc.ByCode._Spec._PresentSSCC
{
    abstract class New_Act : Base_Act
    {
        protected PresentSSCC Sut;
        protected DtoPresentator DtoPresentator = MockRepository.GenerateMock<DtoPresentator>();
        protected ReadAndExcludeCodes ReadAndExcludeCodes = MockRepository.GenerateMock<ReadAndExcludeCodes>();
        protected CodeRepository CodeRepository = MockRepository.GenerateMock<CodeRepository>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new PresentSSCC(ReadAndExcludeCodes, CodeRepository, DtoPresentator);
        }
    }


}