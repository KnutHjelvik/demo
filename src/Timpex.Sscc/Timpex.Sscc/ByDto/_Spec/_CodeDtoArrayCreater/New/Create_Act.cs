using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Sscc.ByDto._Spec._CodeDtoArrayCreater.New
{
    abstract class Create_Act : New_Act
    {
        private static CodeDto dto1 = MockRepository.GenerateMock<CodeDto>();
        private static CodeDto dto2 = MockRepository.GenerateMock<CodeDto>();
        private List<CodeDto> dtos = new List<CodeDto>{dto1,dto2};
        protected static string DtoString1 = "ABCDE";
        protected static string DtoString2 = "ABCDE";
        protected string[] Expected = new[] { DtoString1, DtoString2 };
        protected string[] Returned;
        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            CodeDtoStringCreater.Stub(x => x.Create(dto1)).Return("ABCDE");
            CodeDtoStringCreater.Stub(x => x.Create(dto2)).Return("ABCDE");

        }

        protected override void Act()
        {
            Returned = Sut.Create(dtos);
        }
    }


}