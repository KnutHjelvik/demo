using System.Collections.Generic;
using Rhino.Mocks;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByDto._Spec._DtoPresentator.New
{
    abstract class Present_Act : New_Act
    {
        protected static CodeDto PresentableCode1 = MockRepository.GenerateMock<CodeDto>();
        protected static CodeDto PresentableCode2 = MockRepository.GenerateMock<CodeDto>();
        protected static Code Code1 = MockRepository.GenerateMock<Code>();
        protected static Code Code2 = MockRepository.GenerateMock<Code>();
        protected List<Code> UnPresentedCodes = new List<Code> {Code1, Code2};
        protected List<CodeDto> Expected = new List<CodeDto>{PresentableCode1,PresentableCode2};
        protected List<CodeDto> Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            CodeDtoFactory.Stub(x => x.Create(Code1)).Return(PresentableCode1);
            CodeDtoFactory.Stub(x => x.Create(Code2)).Return(PresentableCode2);
        }

        protected override void Act()
        {
            Returned = Sut.Present(UnPresentedCodes);
        }
    }


}