using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._CodeExtraction.New._ExtractSerialNumber
{
    abstract class ExtractSerialNumber_Act : New_Act
    {
        protected string Expected = "9123456789";


        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Code.Stub(x => x.value).Return("(00)37045679123456789");
        }

        protected override void Act()
        {
            Returned = Sut.ExtractSerialNumber();
        }
    }


}