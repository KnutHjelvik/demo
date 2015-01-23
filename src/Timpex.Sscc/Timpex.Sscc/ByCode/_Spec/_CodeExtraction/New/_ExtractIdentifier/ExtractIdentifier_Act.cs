using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._CodeExtraction.New._ExtractIdentifier
{
    abstract class ExtractIdentifier_Act : New_Act
    {
        protected string Expected = "3";


        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Code.Stub(x => x.value).Return("(00)370456789123456789");
        }

        protected override void Act()
        {
            Returned = Sut.ExtractIdentifier();
        }
    }


}