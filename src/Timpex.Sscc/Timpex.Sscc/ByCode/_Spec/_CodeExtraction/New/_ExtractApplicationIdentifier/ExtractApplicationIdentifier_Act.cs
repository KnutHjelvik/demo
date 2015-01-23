using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._CodeExtraction.New._ExtractApplicationIdentifier
{
    abstract class ExtractApplicationIdentifier_Act : New_Act
    {
        protected string Expected = "(00)";


        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Code.Stub(x => x.value).Return("(00)370456789123456789");
        }

        protected override void Act()
        {
            Returned = Sut.ExtractApplicationIdentifier();
        }
    }


}