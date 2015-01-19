using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._ReadAndExcludeCodes
{
    abstract class New_Act : Base_Act
    {
        protected ReadAndExcludeCodes Sut;
        protected CodeExcluder CodeExcluder = MockRepository.GenerateMock<CodeExcluder>();
        protected ReadCodesCore ReadCodesCore = MockRepository.GenerateMock<ReadCodesCore>();


        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new ReadAndExcludeCodes(ReadCodesCore,CodeExcluder);
        }
    }


}