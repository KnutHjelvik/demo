using System.Collections.Generic;
using Rhino.Mocks;
using Timpex.Sscc.ByDto;

namespace Timpex.Sscc.ByCode._Spec._PresentSSCC.New
{
    abstract class PresentCodes_Act : New_Act
    {
        private static CodeDto _code1 = MockRepository.GenerateMock<CodeDto>();
        private static Code Code1 = MockRepository.GenerateMock<Code>();
        protected List<CodeDto> Expected = new List<CodeDto>{_code1};
        protected const string Location = "path";
        private List<Code> UnpresentableCodes = new List<Code>{Code1};
        protected List<CodeDto> Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            CodeRepository.Stub(x => x.GetLocation()).Return(Location);
            ReadAndExcludeCodes.Stub(x => x.Read(Location)).Return(UnpresentableCodes);
            DtoPresentator.Stub(x => x.Present(UnpresentableCodes)).Return(Expected);
        }

        

        protected override void Act()
        {
            Returned = Sut.PresentCodes();
        }
    }


}