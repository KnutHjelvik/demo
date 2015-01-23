using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._CodeExtraction.New._ExtractSupplier
{
    abstract class ExtractSupplier_Act : New_Act
    {
        protected string Expected = "5678";


        protected string Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            Code.Stub(x => x.value).Return("(00)370456789123456789");
        }

        protected override void Act()
        {
            Returned = Sut.ExtractSupplier();
        }
    }


}