using System.Collections.Generic;
using Rhino.Mocks;
using Timpex.Sscc.ByDto;

namespace Timpex.Sscc.ByIO._Spec._CodeWriter.New
{
    abstract class Write_Act : New_Act
    {
        protected string[] array = {};
        protected List<CodeDto> dtos = new List<CodeDto>();



        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            CodeDtoArrayCreater.Stub(x => x.Create(dtos)).Return(array);
        }

        protected override void Act()
        {
           Sut.Write(dtos); 
        }
    }


}