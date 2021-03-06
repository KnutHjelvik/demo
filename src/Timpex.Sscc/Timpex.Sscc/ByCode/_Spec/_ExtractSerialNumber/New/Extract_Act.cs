﻿using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._ExtractSerialNumber.New
{
    abstract class Extract_Act : New_Act
    {
        protected Code Code = MockRepository.GenerateMock<Code>();
        protected string Expected = "9123456789";
        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Code.Stub(x => x.value).Return("(00)37056789123456789");
        }

        protected override void Act()
        {
            Returned = Sut.Extract(Code);
        }
    }


}